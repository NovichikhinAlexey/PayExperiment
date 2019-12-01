using System.Threading.Tasks;
using Lykke.Service.PayMerchant.Client;
using Lykke.Service.PayMerchant.Client.Models;

namespace Lykke.Service.PayMock.PayMerchant
{
    public class PayMerchantSettingsApiMock : IPayMerchantSettingsApi
    {
        public Task<VolatilitySettingsResponse> GetVolatilitySettingsAsync(string merchantId)
        {
            throw new System.NotImplementedException();
        }

        public Task AddVolatilitySettingsAsync(AddVolatilitySettingsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateVolatilitySettingsAsync(UpdateVolatilitySettingsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteVolatilitySettingsAsync(string merchantId)
        {
            throw new System.NotImplementedException();
        }
    }
}
