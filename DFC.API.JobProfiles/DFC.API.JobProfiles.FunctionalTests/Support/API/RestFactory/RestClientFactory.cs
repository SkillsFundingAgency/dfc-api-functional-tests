using DFC.API.JobProfiles.FunctionalTests.Support.API.RestFactory.Interfaces;
using RestSharp;
using System;

namespace DFC.API.JobProfiles.FunctionalTests.Support.API.RestFactory
{
    internal class RestClientFactory : IRestClientFactory
    {
        public IRestClient Create(Uri baseUrl)
        {
            return new RestClient(baseUrl);
        }
    }
}