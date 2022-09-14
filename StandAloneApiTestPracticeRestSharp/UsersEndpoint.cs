using System;
using RestSharp;
using StandAloneApiTestPracticeRestSharp.DTO;

namespace StandAloneApiTestPracticeRestSharp
{
    public class UsersEndpoint
    {
        public string baseUri = "https://reqres.in/";
        public string apiKey = "asfdsfs";
        public RestResponse GetUsers()
        {
            var restClient = new RestClient(baseUri);
            var restRequest = new RestRequest("api/users?page=2", Method.Get);

            //restRequest.AddParameter("key", apiKey);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            var rawResponse = restClient.Execute(restRequest);
            return rawResponse;
        }

        public RestResponse CreateUser()
        {
            var newUser = new CreateUserRequest()
            {
                name = "Astrid Nersesyan",
                job = "Quality Engineer"
            };
            var restClient = new RestClient(baseUri);
            var restRequest = new RestRequest("api/users", Method.Post);
            restRequest.AddHeader("Accept", "applictaion/json");
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(newUser);
            var rawResponse = restClient.Execute(restRequest);
            return rawResponse;
        }

    }

}

