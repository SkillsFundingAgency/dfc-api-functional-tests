using RestSharp;

namespace DFC.API.JobProfiles.FunctionalTests.Support.API.RestFactory.Interfaces
{
    public interface IRestRequestFactory
    {
        IRestRequest Create(string urlSuffix = null);
    }
}