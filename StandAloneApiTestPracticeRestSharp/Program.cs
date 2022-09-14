// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RestSharp;
using NUnit;
using NUnit.Framework;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using StandAloneApiTestPracticeRestSharp;
using StandAloneApiTestPracticeRestSharp.DTO;

public class Program
{

    public static void Main()

    {
        UsersEndpointTests usersEndpointTests = new UsersEndpointTests();
        usersEndpointTests.RunUsersTests();

    }

}
