using System.Threading.Tasks;
using Autofac;
using Common;
using Common.Log;
using Lykke.Common.Log;
using Lykke.Service.PayInvoice.Contract.Invoice;
using Lykke.Service.PayInvoicePortal.Services;

namespace Lykke.Service.PayInvoicePortal.RabbitSubscribers
{
    public class InvoiceUpdateSubscriber : IStartable, IStopable
    {
        private readonly IRealtimeNotificationsService _realtimeNotificationsService;
        private readonly ILog _log;

        public InvoiceUpdateSubscriber(
            ILogFactory logFactory)
        {
            _log = logFactory.CreateLog(this);
        }

        public void Start()
        {
            _log.Info($"{nameof(InvoiceUpdateSubscriber)} is started.");
        }

        private Task ProcessMessageAsync(InvoiceUpdateMessage message)
        {
            //todo: Implement InvoiceUpdateSignal
            return _realtimeNotificationsService.SendInvoiceUpdateAsync(message);
        }

        public void Dispose()
        {
        }

        public void Stop()
        {
        }
    }
}
