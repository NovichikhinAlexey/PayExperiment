using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.PayInvoice.Client;
using Lykke.Service.PayInvoice.Client.Models.File;
using Lykke.Service.PayInvoice.Client.Models.Invoice;
using Lykke.Service.PayInvoice.Client.Models.MerchantSetting;
using Lykke.Service.PayInvoice.Core.Domain;
using Lykke.Service.PayInvoice.Core.Domain.PaymentRequest;

namespace Lykke.Service.PayMock
{
    public partial class PayInvoiceMock
    {
        public Task<IEnumerable<FileInfoModel>> GetFilesAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetFileAsync(string invoiceId, string fileId)
        {
            throw new NotImplementedException();
        }

        public Task UploadFileAsync(string invoiceId, byte[] content, string fileName, string contentType)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFileAsync(string invoiceId, string fileId)
        {
            throw new NotImplementedException();
        }
    }
}
