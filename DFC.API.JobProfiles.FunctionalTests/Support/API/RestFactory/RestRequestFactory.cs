using DFC.API.JobProfiles.FunctionalTests.Support.API.RestFactory.Interfaces;
using RestSharp;

namespace DFC.API.JobProfiles.FunctionalTests.Support.API.RestFactory
{
    internal class RestRequestFactory : IRestRequestFactory
    {
        public IRestRequest Create(string urlSuffix = null)
        {
            return new RestRequest(urlSuffix);
        }
    }
}