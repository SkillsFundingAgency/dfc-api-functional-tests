using RestSharp;
using System;

namespace DFC.API.JobProfiles.FunctionalTests.Support.API.RestFactory.Interfaces
{
    public interface IRestClientFactory
    {
        IRestClient Create(Uri baseUrl);
    }
}