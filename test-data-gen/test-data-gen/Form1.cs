namespace test_data_gen
{
    using RestSharp;
    public partial class Form1 : Form
    {
        RestClient client;

        List<String> characters = new List<String>();
        
        public Form1()
        {
            InitializeComponent();
            client = new RestClient("https://eu-central-1.aws.data.mongodb-api.com/app/data-eaeag/endpoint/data/v1/action/insertOne");
            characters.Add("Yahya");
            characters.Add("Yahya");
            characters.Add("PR0PH3CY");
            characters.Add("PR0PH3CY");
            characters.Add("Ryge");
            characters.Add("Ryge");
            characters.Add("Harald");
            characters.Add("Harald");
            characters.Add("MF");
            characters.Add("Shadow");
            characters.Add("Shadow");
            characters.Add("Mossell");
            characters.Add("Mossell");
            characters.Add("Crabgot");
            characters.Add("Crabgot");
            characters.Add("Kim");
            characters.Add("Kim");
            characters.Add("Fulcrum");
            characters.Add("Fulcrum");
            characters.Add("Fulcrum");
            characters.Add("Mishima");
            characters.Add("Mishima");
            characters.Add("Mishima");
            characters.Add("Mishima");
            characters.Add("Truck");
            characters.Add("Truck");
        }

        

        private void test_data_gen_Click(object sender, EventArgs e)
        {
            var request = new RestRequest();
            Random random = new Random();

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Access-Control-Request-Headers", "*");
            request.AddHeader("api-key", "skjult"); //Husk at slet før upload

            
            String jsonBody = "{\"collection\":\"matches\",\"database\":\"matchData\",\"dataSource\":\"matchData\",\"document\":{";

            int randomPlayerCount = random.Next(2,10);
            int matchID = random.Next(0, 9999999);
            jsonBody += "\"match_id\":\"" + matchID.ToString() + "\",";
            for (int i = 0; i < randomPlayerCount; i++)
            {
                jsonBody += "\"player" + i.ToString() +"\":{";

                int character = random.Next(0, characters.Count);
                int kills = 0;
                if (i == 0) kills = 35;
                else kills = random.Next(0, 34);
                jsonBody += "\"id\":\""+ i.ToString() + "\",";
                jsonBody += "\"kills\":\"" + kills.ToString() + "\",";
                jsonBody += "\"hero\":\"" + characters[character] + "\"}";
                if (i < randomPlayerCount - 1) jsonBody += ",";
            }

            jsonBody += "}}";

            labelstuff.Text = jsonBody;

            request.AddStringBody(jsonBody, DataFormat.Json);
            RestResponse response = client.Post(request);
        }
    }
}