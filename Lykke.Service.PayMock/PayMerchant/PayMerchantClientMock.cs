using Lykke.Service.PayMerchant.Client;

namespace Lykke.Service.PayMock.PayMerchant
{
    public class PayMerchantClientMock : IPayMerchantClient
    {
        public PayMerchantClientMock()
        {
            Api = new PayMerchantApiMock();
            Groups = new PayMerchantGroupsApiMock();
            Settings = new PayMerchantSettingsApiMock();
        }

        public IPayMerchantApi Api { get; }
        public IPayMerchantGroupsApi Groups { get; }
        public IPayMerchantSettingsApi Settings { get; set; }
    }
}
