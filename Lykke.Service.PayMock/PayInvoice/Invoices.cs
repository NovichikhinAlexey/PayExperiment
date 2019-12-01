using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.PayInvoice.Client;
using Lykke.Service.PayInvoice.Client.Models.Invoice;
using Lykke.Service.PayInvoice.Core.Domain;
using Lykke.Service.PayInvoice.Core.Domain.PaymentRequest;

namespace Lykke.Service.PayMock
{
    public partial class PayInvoiceMock : IPayInvoiceClient
    {
        public Task<InvoiceModel> GetInvoiceAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasAnyInvoiceAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<InvoiceModel>> GetByFilter(IEnumerable<string> merchantIds, IEnumerable<string> clientMerchantIds, IEnumerable<string> statuses, bool? dispute,
            IEnumerable<string> billingCategories, decimal? greaterThan, decimal? lessThan)
        {
            throw new NotImplementedException();
        }

        public Task<GetByPaymentsFilterResponse> GetByPaymentsFilterAsync(string merchantId, IEnumerable<string> statuses, DateTime? dateFrom, DateTime? dateTo,
            string searchText, int? take)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<HistoryItemModel>> GetInvoiceHistoryAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<PaymentRequestHistoryItem>> GetPaymentRequestsAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<InvoiceModel> CreateInvoiceAsync(CreateInvoiceModel model)
        {
            throw new NotImplementedException();
        }

        public Task<InvoiceModel> CreateInvoiceAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<InvoiceModel> ChangePaymentAssetAsync(string invoiceId, string paymentAssetId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInvoiceAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task PayInvoicesAsync(PayInvoicesRequest model)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetSumToPayInvoicesAsync(GetSumToPayInvoicesRequest model)
        {
            throw new NotImplementedException();
        }

        public Task MarkDisputeAsync(MarkInvoiceDisputeRequest model)
        {
            throw new NotImplementedException();
        }

        public Task CancelDisputeAsync(CancelInvoiceDisputeRequest model)
        {
            throw new NotImplementedException();
        }

        public Task<InvoiceDisputeInfoResponse> GetInvoiceDisputeInfoAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InvoiceModel>> GetMerchantInvoicesAsync(string merchantId)
        {
            throw new NotImplementedException();
        }
        
        public Task<MerchantSetting> SetMerchantSettingAsync(MerchantSetting model)
        {
            throw new NotImplementedException();
        }


        public Task<InvoiceModel> CreateDraftInvoiceAsync(CreateInvoiceModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDraftInvoiceAsync(UpdateInvoiceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
