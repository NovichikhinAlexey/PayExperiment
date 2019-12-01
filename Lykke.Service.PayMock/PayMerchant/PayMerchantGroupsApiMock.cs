using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.PayMerchant.Client;
using Lykke.Service.PayMerchant.Client.Models;

namespace Lykke.Service.PayMock.PayMerchant
{
    public class PayMerchantGroupsApiMock : IPayMerchantGroupsApi
    {
        public Task<MerchantGroupResponse> AddGroupAsync(AddMerchantGroupRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<MerchantGroupResponse> GetGroupAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateGroupAsync(UpdateMerchantGroupRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteGroupAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<MerchantsByUsageResponse> GetMerchantsByUsageAsync(GetMerchantsByUsageRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<MerchantGroupResponse>> GetGroupsByOwnerAsync(string ownerId)
        {
            throw new System.NotImplementedException();
        }
    }
}
