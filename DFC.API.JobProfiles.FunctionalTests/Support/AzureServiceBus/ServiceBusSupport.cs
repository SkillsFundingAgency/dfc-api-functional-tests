using DFC.API.JobProfiles.FunctionalTests.Model.Support;
using DFC.API.JobProfiles.FunctionalTests.Support.AzureServiceBus.ServiceBusFactory.Interfaces;
using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;

namespace DFC.API.JobProfiles.FunctionalTests.Support.AzureServiceBus
{
    public class ServiceBusSupport : IServiceBusSupport
    {
        private readonly ITopicClientFactory topicClientFactory;
        private readonly AppSettings appSettings;

        public ServiceBusSupport(ITopicClientFactory topicClientFactory, AppSettings appSettings)
        {
            this.topicClientFactory = topicClientFactory;
            this.appSettings = appSettings;
        }

        public async Task SendMessage(Message message)
        {
            var topicClient = this.topicClientFactory.Create(this.appSettings.ServiceBusConfig.ConnectionString);
            await topicClient.SendAsync(message).ConfigureAwait(false);
        }
    }
}