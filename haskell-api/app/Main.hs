{-# LANGUAGE DataKinds #-}
{-# LANGUAGE TypeOperators #-}
{-# LANGUAGE OverloadedStrings #-}
{-# LANGUAGE DeriveGeneric #-}

import Network.Wai.Handler.Warp
import Servant
import Database.MongoDB
import Data.Aeson
import GHC.Generics
import System.Environment (lookupEnv)
import Control.Monad.IO.Class (liftIO)
import Data.Text (pack)



--temporary structure while testing, will be made into the actual structure once the rest works
data MatchStructure = MatchStructure
    { field1 :: String
    , field2 :: Int
    } deriving (Generic, Show)

instance FromJSON MatchStructure
instance ToJSON MatchStructure


getMongoConnectionString :: IO String
getMongoConnectionString = do
    maybeConnectionString <- lookupEnv "MONGO_CONNECTION_STRING"
    case maybeConnectionString of
        Just connStr -> return connStr
        Nothing -> error "MongoDB connection string not found in environment variables"

getMongoDatabaseName :: IO String
getMongoDatabaseName = do
    maybeDBName <- lookupEnv "MONGO_DATABASE_NAME"
    case maybeDBName of
        Just dbName -> return dbName
        Nothing -> error "MongoDB database name not found in environment variables"

getMongoCollectionName :: IO String
getMongoCollectionName = do
    maybeColName <- lookupEnv "MONGO_COLLECTION_NAME"
    case maybeColName of
        Just colName -> return colName
        Nothing -> error "MongoDB collection name not found in environment variables"




storeMatchHandler :: MatchStructure -> Handler String
storeMatchHandler document = do
    connStr <- liftIO getMongoConnectionString
    dbName <- liftIO getMongoDatabaseName
    colName <- liftIO getMongoCollectionName
    
    --let connStrText = pack connStr
    let dbNameText = pack dbName
    let colNameText = pack colName


    rs <- liftIO $ openReplicaSetSRV connStr
    let active_connection = primary rs
    pipe <- liftIO active_connection

    let post = ["field1" =: field1 document, "field2" =: field2 document]
    access pipe master dbNameText $ insert colNameText post
    liftIO $ close pipe
    return "Match stored successfully"

retrieveMatchFromMongo :: Handler MatchStructure
retrieveMatchFromMongo = do
    connStr <- liftIO getMongoConnectionString
    dbName <- liftIO getMongoDatabaseName
    colName <- liftIO getMongoCollectionName
    
    --let connStrText = pack connStr
    let dbNameText = pack dbName
    let colNameText = pack colName

    
    rs <- liftIO $ openReplicaSetSRV connStr
    let active_connection = primary rs
    pipe <- liftIO active_connection

    result <- access pipe master dbNameText $ findOne (select [] colNameText)
    liftIO $ close pipe

    case result of
        Just doc -> return $ MatchStructure
                        { field1 = at "field1" doc
                        , field2 = at "field2" doc
                        }
        Nothing -> return $ MatchStructure "" 0


retrieveMatchHandler :: Handler MatchStructure
retrieveMatchHandler = retrieveMatchFromMongo

server :: Server MatchAPI
server = storeMatchHandler :<|> retrieveMatchHandler

type MatchAPI = "storeMatch" :> ReqBody '[JSON] MatchStructure :> Post '[JSON] String
        :<|> "getMatch" :> Get '[JSON] MatchStructure

matchAPI :: Proxy MatchAPI
matchAPI = Proxy

app :: Application
app = serve matchAPI server

main :: IO ()
main = run 8080 app