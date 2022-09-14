using Newtonsoft.Json;
using RestSharp;
using NUnit;
using NUnit.Framework;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using StandAloneApiTestPracticeRestSharp;
using StandAloneApiTestPracticeRestSharp.DTO;

namespace StandAloneApiTestPracticeRestSharp
{
    public class UsersEndpointTests
    {
        public void RunUsersTests()
        {

            UsersEndpoint usersEndpoint = new UsersEndpoint();
            var getResponse = usersEndpoint.GetUsers();
            if (getResponse.IsSuccessful)
            {
                //HttpStatusCode ActualResponseStatus = JsonConvert.DeserializeObject<HttpStatusCode>(response.StatusCode.);
                var statusCode = getResponse.StatusCode;
                var code = (int)statusCode;
                Assert.AreEqual(200, code);
                Assert.AreEqual("OK", getResponse.StatusDescription);
                ListOfUsersResponse responseContent = JsonConvert.DeserializeObject<ListOfUsersResponse>(getResponse.Content);
                Assert.AreEqual(2, responseContent.Page);
            }
            var postResponse = usersEndpoint.CreateUser();

            CreateUserResponse createUserResponse = JsonConvert.DeserializeObject<CreateUserResponse>(postResponse.Content);
            Assert.AreEqual("Created", postResponse.StatusDescription);
            Assert.AreEqual("Astrid Nersesyan", createUserResponse.name);
        }

    }
}

