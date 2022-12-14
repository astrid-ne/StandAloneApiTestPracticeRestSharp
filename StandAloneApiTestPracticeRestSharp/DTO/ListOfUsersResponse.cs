using System;
namespace StandAloneApiTestPracticeRestSharp.DTO
{
    public class ListOfUsersResponse
    {

        public long Page { get; set; }
        public long PerPage { get; set; }
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public List<Data> Data { get; set; }

    }

    public class Data
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Uri Avatar { get; set; }
    }

}

