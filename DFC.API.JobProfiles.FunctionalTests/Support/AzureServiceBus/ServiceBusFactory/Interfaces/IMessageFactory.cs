using Microsoft.Azure.ServiceBus;

namespace DFC.API.JobProfiles.FunctionalTests.Support.AzureServiceBus.ServiceBusFactory.Interfaces
{
    public interface IMessageFactory
    {
        Message Create(string messageId, byte[] messageBody, string actionType, string contentType);
    }
}