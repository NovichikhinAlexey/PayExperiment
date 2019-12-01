using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.RateCalculator.Client;
using Lykke.Service.RateCalculator.Client.AutorestClient.Models;

namespace Lykke.Service.PayMock.RateCalculator
{
    public class RateCalculatorClientMock : IRateCalculatorClient
    {
        public Task<double> GetRateAsync(string neededAssetId, AssetPair assetPair, double price)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<BalanceRecordWithBase>> FillBaseAssetDataAsync(IEnumerable<BalanceRecord> balanceRecords, string baseAssetId)
        {
            throw new System.NotImplementedException();
        }

        public Task<BalanceRecordWithBase> FillBaseAssetDataAsync(BalanceRecord balanceRecord, string baseAssetId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<BalanceRecord>> GetAmountInBaseAsync(IEnumerable<BalanceRecord> balanceRecords, string toAssetId)
        {
            throw new System.NotImplementedException();
        }

        public Task<double> GetAmountInBaseAsync(string assetFrom, double amount, string assetTo)
        {
            throw new System.NotImplementedException();
        }

        public Task<double> GetAmountInBaseWithProfileAsync(string assetFrom, double amount, string assetTo, MarketProfile marketProfile)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ConversionResult>> GetMarketAmountInBaseAsync(IEnumerable<AssetWithAmount> assetsFrom, string assetIdTo, OrderAction orderAction)
        {
            throw new System.NotImplementedException();
        }

        public Task<MarketProfile> GetMarketProfileAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<double> GetBestPriceAsync(string assetPair, bool buy)
        {
            throw new System.NotImplementedException();
        }
    }
}
