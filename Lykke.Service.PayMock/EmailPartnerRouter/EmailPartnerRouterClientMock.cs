using System.Threading.Tasks;
using Lykke.Service.EmailPartnerRouter.Client;
using Lykke.Service.EmailPartnerRouter.Contracts;

namespace Lykke.Service.PayMock.EmailPartnerRouter
{
    public class EmailPartnerRouterClientMock : IEmailPartnerRouterClient
    {
        public Task Send(SendEmailCommand cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
