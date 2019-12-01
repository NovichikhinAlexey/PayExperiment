using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.PayInvoice.Client;
using Lykke.Service.PayInvoice.Client.Models.MerchantSetting;
using Lykke.Service.PayInvoice.Core.Domain;

namespace Lykke.Service.PayMock
{
    public partial class PayInvoiceMock : IPayInvoiceClient
    {
        private Dictionary<string, string> _baseAsset = new Dictionary<string, string>()
        {
            { "default", "USD" }
        };

        public async Task<string> GetBaseAssetAsync(string merchantId)
        {
            if (_baseAsset.TryGetValue(merchantId, out var asset))
            {
                return asset;
            }

            return "USD";
        }

        public async Task SetBaseAssetAsync(UpdateBaseAssetRequest model)
        {
            _baseAsset[model.MerchantId] = model.BaseAsset;
        }

        public async Task<MerchantSetting> GetMerchantSettingAsync(string merchantId)
        {
            if (_baseAsset.TryGetValue(merchantId, out var asset))
            {
                return new MerchantSetting()
                {
                    MerchantId = merchantId,
                    BaseAsset = asset
                };
            }

            throw new Exception($"Merchant '{merchantId}' not found");
        }
    }
}
