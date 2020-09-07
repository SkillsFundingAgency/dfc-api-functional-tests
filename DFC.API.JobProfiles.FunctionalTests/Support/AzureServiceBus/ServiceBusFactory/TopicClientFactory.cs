using DFC.API.JobProfiles.FunctionalTests.Support.AzureServiceBus.ServiceBusFactory.Interfaces;
using Microsoft.Azure.ServiceBus;

namespace DFC.API.JobProfiles.FunctionalTests.Support.AzureServiceBus.ServiceBusFactory
{
    public class TopicClientFactory : ITopicClientFactory
    {
        public ITopicClient Create(string connectionString)
        {
            return new TopicClient(new ServiceBusConnectionStringBuilder(connectionString));
        }
    }
}