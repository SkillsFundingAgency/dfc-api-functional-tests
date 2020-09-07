using Microsoft.Azure.ServiceBus;

namespace DFC.API.JobProfiles.FunctionalTests.Support.AzureServiceBus.ServiceBusFactory.Interfaces
{
    public interface ITopicClientFactory
    {
        ITopicClient Create(string connectionString);
    }
}