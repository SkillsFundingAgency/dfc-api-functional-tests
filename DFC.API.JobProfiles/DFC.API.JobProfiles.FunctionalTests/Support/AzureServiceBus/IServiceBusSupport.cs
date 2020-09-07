using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;

namespace DFC.API.JobProfiles.FunctionalTests.Support.AzureServiceBus
{
    public interface IServiceBusSupport
    {
        Task SendMessage(Message message);
    }
}
