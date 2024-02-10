using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace DemoProject.Helpers
{
    internal class APIHelper
    {
        public RestClient client;
        public RestRequest request;
        private const string base_url = "https://reqres.in/";

        public RestClient SetURL ()
        {
            client = new RestClient();
            return client;
        }

        public RestRequest CreateGetRequest(string endpoint)
        {
            var url = Path.Combine(base_url, endpoint);
            request = new RestRequest(base_url, Method.Get);
            request.AddHeader("Accept", "application/json");
            return request;

        }

        public RestRequest PostRestRequest (string base_url, string endpoint,string body)
        {
            var url = Path.Combine(base_url, endpoint);
            request = new RestRequest(base_url, Method.Get);
            request.AddHeader("Accept", "application/json");
            request.AddBody(body);
            return request;
        }

        public RestRequest PutRestRequest(string base_url, string endpoint, string body)
        {
            var url = Path.Combine(base_url, endpoint);
            request = new RestRequest(base_url, Method.Get);
            request.AddHeader("Accept", "application/json");
            request.AddBody(body);
            return request;
        }

        public RestRequest PatchRequest(string baseurl, string endpoint, string body)
        {
            var url = Path.Combine(baseurl, endpoint);
            request = new RestRequest(url, Method.Patch);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            return request;
        }
        public RestResponse GetResponse(RestClient restClient, RestRequest request)
        {
            return restClient.Execute(request);
        }
    }
}

