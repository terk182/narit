using App.ExampleTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ExampleTest
{
    public class ExampleTests : IExampleTests
    {
        private readonly string _webAPIBaseUrl;
        protected string _accessToken;

        public ExampleTests(string accessToken = "", string webAPIBaseUrl = "https://fairfairbackoffice.azurewebsites.net/api/FairFair")
        {
            _accessToken = accessToken;
            _webAPIBaseUrl = webAPIBaseUrl;
        }

        public ExData testDi(int id, string name)
        {
            var data = new ExData();
            data.Id = id;
            data.Name = name;
            return data;
        }
    }
}
