using System;
using DemoProject.Helpers;
using DemoProject.Model;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace DemoProject.StepDefinitions
{
    [Binding]
    public class TestAccountAPIStepDefinitions
    {
        private const string BASE_URL = "https://www.localhost:8080/";
        private const string endpoint = "api/account/create";

        APISources api = new APISources();
        private readonly CreateUserRequest createUserRequest;
        private RestResponse response;

        TestAccountAPIStepDefinitions(CreateUserRequest createUserRequest)
        {
             this.createUserRequest = createUserRequest;
        }

        [Given(@"Account Initial Balance is ""([^""]*)""")]
        public void GivenAccountInitialBalanceIs(string balance)
        {
            createUserRequest.InitialBalance = balance;
        }

        [Given(@"Account name is ""([^""]*)""")]
        public void GivenAccountNameIs(string accountname)
        {
            createUserRequest.AccountName = accountname;
        }

        [Given(@"Address is ""([^""]*)""")]
        public void GivenAddressIs(string address)
        {
            createUserRequest.Address = address;
        }

        [When(@"POST endpoint triggered to create new account with above details")]
        public void WhenPOSTEndpointTriggeredToCreateNewAccountWithAboveDetails()
        {
            api.CreateAccount(BASE_URL, endpoint,createUserRequest);
        }

        [Then(@"Verify the response code is (.*)")]
        public void ThenVerifyTheResponseCodeIs(int responsecode)
        {
            Assert.AreEqual(200, response.StatusCode);
        }

        [Then(@"Verify no error is returned")]
        public void ThenVerifyNoErrorIsReturned()
        {
            var content = HandleData.GetContent<CreateUserResponse>(response);
            Assert.AreEqual("Account not created sucessfully", content.ErrorResponse);
        }

        [Then(@"Verify the success message “Account created successfully”")]
        public void ThenVerifyTheSuccessMessageAccountCreatedSuccessfully()
        {
            var content = HandleData.GetContent<CreateUserResponse>(response);
            Assert.AreEqual("Account not created sucessfully", content.sucessmessage);
        }

        [Then(@"Verify the account details are correctly returned in the JSON response")]
        public void ThenVerifyTheAccountDetailsAreCorrectlyReturnedInTheJSONResponse()
        {
            var content = HandleData.GetContent<CreateUserResponse>(response);
        
        }

        [When(@"Put endpoint triggered to create new account with above details")]
        public void WhenPutEndpointTriggeredToCreateNewAccountWithAboveDetails()
        {
            api.PutAccount(BASE_URL, endpoint, createUserRequest);
        }

        [When(@"Delete endpoint triggered to create new account with above details")]
        public void WhenDeleteEndpointTriggeredToCreateNewAccountWithAboveDetails()
        {
            api.DeleteAccount(BASE_URL, endpoint, createUserRequest);
        }

    }
}
