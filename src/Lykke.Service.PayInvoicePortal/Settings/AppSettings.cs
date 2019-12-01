using Lykke.Service.PayInvoicePortal.Settings.ServiceSettings;
using Lykke.Service.PayInvoicePortal.Core.Domain.Settings.AppSettings;

namespace Lykke.Service.PayInvoicePortal.Settings
{
    public class AppSettings
    {
        public PayInvoicePortalSettings PayInvoicePortal { get; set; }
        public AssetsMapSettings AssetsMap { get; set; }
    }
}
