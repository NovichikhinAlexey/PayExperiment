using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.PayMerchant.Client;
using Lykke.Service.PayMerchant.Client.Models;

namespace Lykke.Service.PayMock.PayMerchant
{
    public class PayMerchantApiMock : IPayMerchantApi
    {
        public Task<IReadOnlyList<MerchantModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<MerchantModel> GetByIdAsync(string merchantId)
        {
            throw new System.NotImplementedException();
        }

        public Task<MerchantModel> CreateAsync(CreateMerchantRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(UpdateMerchantRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string merchantId)
        {
            throw new System.NotImplementedException();
        }
    }
}
