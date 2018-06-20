using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace API_Tests
{
    [Binding]
    public class FeatureModeloSteps
    {
        private RestClient client;
        private RestRequest request;
        private IRestResponse response;

        [When(@"realizo a requisição GET")]
        public void QuandoRealizoARequisicaoGET()
        {
            client = new RestClient("https://restcountries.eu/rest/v1/callingcode/65");
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
        }
        
        [Then(@"devo receber o retorno (.*) - OK")]
        public void EntaoDevoReceberORetorno_OK(int p0)
        {
            //Console.WriteLine("\n" + response.Content + "\n");

            string json = response.Content;
            string jsonFormatted = JValue.Parse(json).ToString(Formatting.Indented);
            Console.WriteLine("\n" + jsonFormatted + "\n");

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
