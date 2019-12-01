using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.PayInternal.Client;
using Lykke.Service.PayInternal.Client.Models.Asset;
using Lykke.Service.PayInternal.Client.Models.AssetRates;
using Lykke.Service.PayInternal.Client.Models.Cashout;
using Lykke.Service.PayInternal.Client.Models.Exchange;
using Lykke.Service.PayInternal.Client.Models.File;
using Lykke.Service.PayInternal.Client.Models.Markup;
using Lykke.Service.PayInternal.Client.Models.MerchantWallets;
using Lykke.Service.PayInternal.Client.Models.Order;
using Lykke.Service.PayInternal.Client.Models.PaymentRequest;
using Lykke.Service.PayInternal.Client.Models.SupervisorMembership;
using Lykke.Service.PayInternal.Client.Models.Transactions;
using Lykke.Service.PayInternal.Client.Models.Transactions.Ethereum;
using Lykke.Service.PayInternal.Client.Models.Validation;
using Lykke.Service.PayInternal.Client.Models.Wallets;

namespace Lykke.Service.PayMock.PayInternal
{
    public class PayInternalClientMock : IPayInternalClient
    {
        public Task<IEnumerable<WalletStateResponse>> GetNotExpiredWalletsAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreatePaymentTransactionAsync(CreateTransactionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task CreateLykkePaymentTransactionAsync(CreateLykkeTransactionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTransactionAsync(UpdateTransactionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetOrderAsync(string paymentRequestId, string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> ChechoutOrderAsync(ChechoutRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CalculatedAmountResponse> GetCalculatedAmountInfoAsync(GetCalculatedAmountInfoRequest model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasAnyPaymentRequestAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<GetByPaymentsFilterResponse> GetByPaymentsFilterAsync(string merchantId, IEnumerable<string> statuses, IEnumerable<string> processingErrors, DateTime? dateFrom,
            DateTime? dateTo, int? take)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<PaymentRequestModel>> GetPaymentRequestsAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentRequestModel> GetPaymentRequestAsync(string merchantId, string paymentRequestId)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentRequestDetailsModel> GetPaymentRequestDetailsAsync(string merchantId, string paymentRequestId)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentRequestModel> GetPaymentRequestByAddressAsync(string walletAddress)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentRequestModel> CreatePaymentRequestAsync(CreatePaymentRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<BtcTransferResponse> BtcFreeTransferAsync(BtcFreeTransferRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransactionStateResponse>> GetAllMonitoredTransactionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RefundResponse> RefundAsync(RefundRequestModel request)
        {
            throw new NotImplementedException();
        }

        public Task SetTransactionExpiredAsync(TransactionExpiredRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AvailableAssetsResponse> ResolveAvailableAssetsAsync(string merchantId, AssetAvailabilityType type)
        {
            throw new NotImplementedException();
        }

        public Task<AvailableAssetsResponse> GetAvailableSettlementAssetsAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<AvailableAssetsResponse> GetAvailablePaymentAssetsAsync(string merchantId, string settlementAssetId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AssetGeneralSettingsResponse>> GetAssetGeneralSettingsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AssetMerchantSettingsResponse> GetAssetMerchantSettingsAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task SetAssetGeneralSettingsAsync(UpdateAssetGeneralSettingsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task SetAssetMerchantSettingsAsync(UpdateAssetMerchantSettingsRequest settingsRequest)
        {
            throw new NotImplementedException();
        }

        public Task CancelAsync(string merchantId, string paymentRequestId)
        {
            throw new NotImplementedException();
        }

        public Task SetWalletExpiredAsync(BlockchainWalletExpiredRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MarkupResponse> ResolveMarkupByMerchantAsync(string merchantId, string assetPairId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<MarkupResponse>> GetDefaultMarkupsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MarkupResponse> GetDefaultMarkupAsync(string assetPairId)
        {
            throw new NotImplementedException();
        }

        public Task SetDefaultMarkupAsync(string assetPairId, UpdateMarkupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<MarkupResponse>> GetMarkupsForMerchantAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<MarkupResponse> GetMarkupForMerchantAsync(string merchantId, string assetPairId)
        {
            throw new NotImplementedException();
        }

        public Task SetMarkupForMerchantAsync(string merchantId, string assetPairId, UpdateMarkupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<SupervisorMembershipResponse> AddSupervisorMembershipAsync(AddSupervisorMembershipRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<SupervisorMembershipResponse> GetSupervisorMembershipAsync(string employeeId)
        {
            return new SupervisorMembershipResponse()
            {
                MerchantId = DemoData.DemoMerchantId,
                EmployeeId = DemoData.DemoEmployeeId,
                MerchantGroups = new List<string>()
            };
        }

        public Task UpdateSupervisorMembershipAsync(UpdateSupervisorMembershipRequest request)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSupervisorMembershipAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<MerchantsSupervisorMembershipResponse> AddSupervisorMembershipForMerchantsAsync(AddSupervisorMembershipMerchantsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MerchantsSupervisorMembershipResponse> GetSupervisorMembershipWithMerchantsAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileInfoModel>> GetFilesAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetFileAsync(string merchantId, string fileId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetMerchantLogoUrl(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task UploadFileAsync(string merchantId, byte[] content, string fileName, string contentType)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFileAsync(string merchantId, string fileId)
        {
            throw new NotImplementedException();
        }

        public Task<MerchantWalletResponse> CreateMerchantWalletAsync(CreateMerchantWalletRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMerchantWalletAsync(string merchantWalletId)
        {
            throw new NotImplementedException();
        }

        public Task SetMerchantWalletDefaultAssetsAsync(UpdateMerchantWalletDefaultAssetsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MerchantWalletResponse>> GetMerchantWalletsAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<MerchantWalletResponse> GetDefaultMerchantWalletAsync(string merchantId, string assetId, PaymentDirection paymentDirection)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MerchantWalletBalanceResponse>> GetMerchantWalletBalancesAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<AssetRateResponse> AddAssetPairRateAsync(AddAssetRateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AssetRateResponse> GetCurrentAssetPairRateAsync(string baseAssetId, string quotingAssetId)
        {
            throw new NotImplementedException();
        }

        public Task PayAsync(PaymentRequest request)
        {
            throw new NotImplementedException();
        }

        public Task PrePayAsync(PrePaymentRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ExchangeResponse> ExchangeAsync(ExchangeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ExchangeResponse> PreExchangeAsync(PreExchangeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task RegisterEthereumInboundTransactionAsync(RegisterInboundTxModel request)
        {
            throw new NotImplementedException();
        }

        public Task RegisterEthereumOutboundTransactionAsync(RegisterOutboundTxModel request)
        {
            throw new NotImplementedException();
        }

        public Task CompleteEthereumOutboundTransactionAsync(CompleteOutboundTxModel request)
        {
            throw new NotImplementedException();
        }

        public Task FailEthereumOutboundTransactionAsync(FailOutboundTxModel request)
        {
            throw new NotImplementedException();
        }

        public Task FailEthereumOutboundTransactionAsync(NotEnoughFundsOutboundTxModel request)
        {
            throw new NotImplementedException();
        }

        public Task<CashoutResponse> CashoutAsync(CashoutRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ValidateDepositTransferResult> ValidateDepositTransferAsync(ValidateDepositTransferRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
