using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace DemoProject.Helpers
{
    public  class APISources
    {
        APIHelper helper;
        public APISources()
        {
            helper = new APIHelper();       
        }

        public RestResponse GetResponse (string url)
        {
            var client = helper.SetURL();
            var request = helper.CreateGetRequest("api/users?page=2");
            request.RequestFormat = DataFormat.Json;
            var response = helper.GetResponse(client, request);
            return response;
        }

        public RestResponse CreateAccount (string url,string endpoint, dynamic payload)
        {
            var client = helper.SetURL(); ;
            var json = HandleData.SerializeJsonString(payload);
            var request = helper.PostRestRequest(url, endpoint, payload);
            var response = helper.GetResponse(client, request);
            return response;
        }

        public RestResponse PutAccount(string baseurl, string endpoint, dynamic payload)
        {
            var client = helper.SetURL();
            var jsonstring = HandleData.SerializeJsonString(payload);
            var request = helper.PutRestRequest(baseurl, endpoint, jsonstring);
            var response = helper.GetResponse(client, request);
            return response;
        }

        public RestResponse DeleteAccount(string baseurl, string endpoint, dynamic payload)
        {
            var client = helper.SetURL();
            var jsonstring = HandleData.SerializeJsonString(payload);
            var request = helper.PutRestRequest(baseurl, endpoint, jsonstring);
            var response = helper.GetResponse(client, request);
            return response;
        }

        public RestResponse PatchUsers(string baseurl, string endpoint, dynamic payload)
        {
            var client = helper.SetURL();
            var jsonstring = HandleData.SerializeJsonString(payload);
            var request = helper.PatchRequest(baseurl, endpoint, jsonstring);
            var response = helper.GetResponse(client, request);
            return response;
        }
    }
}
