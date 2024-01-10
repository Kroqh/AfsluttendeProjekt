using PM_GUI_Client.Model_layer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_GUI_Client.Service_layer
{
    

    internal class Connection
    {
        public static async Task<String> GetMatchesJSON()
        {
            RestClient client = new RestClient("https://eu-central-1.aws.data.mongodb-api.com/app/data-eaeag/endpoint/data/v1/action/find");

            String jsonBody = "{\"collection\":\"matches\",\"database\":\"matchData\",\"dataSource\":\"matchData\"}";
            RestRequest request = CreateRequest();
            request.AddStringBody(jsonBody, DataFormat.Json);
            RestResponse response = client.Post(request);
            if (response.IsSuccessStatusCode && response.Content != null)
            {
                return response.Content;
            }
            else
            {
                return "error";
            }
        }
        public static RestRequest CreateRequest()
        {
            RestRequest request = new RestRequest();
            Random random = new Random();

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Access-Control-Request-Headers", "*");
            request.AddHeader("api-key", "skjult");

            return request;
        }


    }
}
