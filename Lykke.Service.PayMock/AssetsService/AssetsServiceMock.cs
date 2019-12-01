using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Lykke.Service.Assets.Client;
using Lykke.Service.Assets.Client.Models;
using Microsoft.Rest;
using Newtonsoft.Json;

namespace Lykke.Service.PayMock.AssetsService
{
    public class AssetsServiceMock: IAssetsService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetAttributes>> AssetAttributeGetAllForAssetWithHttpMessagesAsync(string assetId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetAttributeUpdateWithHttpMessagesAsync(string assetId, AssetAttribute attribute = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetAttributeAddWithHttpMessagesAsync(string assetId, AssetAttribute attribute = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetAttribute>> AssetAttributeGetWithHttpMessagesAsync(string assetId, string key, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetAttributeRemoveWithHttpMessagesAsync(string assetId, string key, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetAttributes>>> AssetAttributeGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetCategory>>> AssetCategoryGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetCategoryUpdateWithHttpMessagesAsync(AssetCategory assetCategory = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetCategory>> AssetCategoryAddWithHttpMessagesAsync(AssetCategory assetCategory = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetCategory>> AssetCategoryGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetCategoryRemoveWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetConditionLayerModel>>> AssetConditionGetLayersWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionUpdateLayerWithHttpMessagesAsync(EditAssetConditionLayerModel model = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionAddLayerWithHttpMessagesAsync(EditAssetConditionLayerModel model = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<object>> AssetConditionGetLayerByIdWithHttpMessagesAsync(string layerId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetConditionDeleteLayerWithHttpMessagesAsync(string layerId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionUpdateAssetConditionWithHttpMessagesAsync(string layerId, EditAssetConditionModel model = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionAddAssetConditionWithHttpMessagesAsync(string layerId, EditAssetConditionModel model = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetConditionDeleteAssetConditionWithHttpMessagesAsync(string layerId, string asset,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionUpdateDefaultAssetConditionWithHttpMessagesAsync(string layerId,
            EditAssetDefaultConditionModel model = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionAddDefaultAssetConditionWithHttpMessagesAsync(string layerId,
            EditAssetDefaultConditionModel model = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetConditionDeleteDefaultAssetConditionWithHttpMessagesAsync(string layerId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionAddLayerToClientWithHttpMessagesAsync(string clientId, string layerId,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionRemoveLayerFromClientWithHttpMessagesAsync(string clientId, string layerId,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<object>> AssetConditionGetLayersByClientIdWithHttpMessagesAsync(string clientId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetDefaultConditionLayerModel>> AssetConditionGetDefaultLayerWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ErrorResponse>> AssetConditionUpdateDefaultLayerWithHttpMessagesAsync(EditAssetDefaultConditionLayerModel model = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetExtendedInfo>>> AssetExtendedInfoGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetExtendedInfoUpdateWithHttpMessagesAsync(AssetExtendedInfo assetInfo = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetExtendedInfo>> AssetExtendedInfoAddWithHttpMessagesAsync(AssetExtendedInfo assetInfo = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> AssetExtendedInfoExistsWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetExtendedInfo>> AssetExtendedInfoGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetExtendedInfoRemoveWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetExtendedInfo>> AssetExtendedInfoGetDefaultWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetGroup>>> AssetGroupGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetGroupUpdateWithHttpMessagesAsync(AssetGroup @group = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetGroup>> AssetGroupAddWithHttpMessagesAsync(AssetGroup @group = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetGroupAddAssetWithHttpMessagesAsync(string assetId, string groupName, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetGroupRemoveAssetWithHttpMessagesAsync(string assetId, string groupName, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetGroupAddClientWithHttpMessagesAsync(string clientId, string groupName, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetGroupRemoveClientWithHttpMessagesAsync(string clientId, string groupName, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetGroupAddOrReplaceClientWithHttpMessagesAsync(string clientId, string groupName,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetGroup>> AssetGroupGetWithHttpMessagesAsync(string groupName, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetGroupRemoveWithHttpMessagesAsync(string groupName, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<string>>> AssetGroupGetAssetIdsWithHttpMessagesAsync(string groupName, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<string>>> AssetGroupGetClientIdsWithHttpMessagesAsync(string groupName, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetPair>>> AssetPairGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetPairUpdateWithHttpMessagesAsync(AssetPair assetPair = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetPair>> AssetPairAddWithHttpMessagesAsync(AssetPair assetPair = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> AssetPairExistsWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetPair>> AssetPairGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetPairRemoveWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetPair>> AssetPairGetDefaultWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> UpdateAssetPairsCacheWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<object>> GetAssetPairWithHttpMessagesAsync(string assetPairId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetPairResponseModel>>> GetAssetPairsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<Asset>>> AssetGetAllWithHttpMessagesAsync(bool includeNonTradable, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetUpdateWithHttpMessagesAsync(Asset asset = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Asset>> AssetAddWithHttpMessagesAsync(Asset asset = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetDisableWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetEnableWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> AssetExistsWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Asset>> AssetGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetRemoveWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ListOfAsset>> AssetGetBySpecificationWithHttpMessagesAsync(AssetSpecification specification = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetCategory>> AssetGetCategoryWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Asset>> AssetGetDefaultWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> UpdateAssetsCacheWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<object>> GetAssetWithHttpMessagesAsync(string assetId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetResponseModel>>> GetAssetsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ListOfAssetSettings>> AssetSettingsGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetSettingsUpdateWithHttpMessagesAsync(AssetSettings settings = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetSettings>> AssetSettingsAddWithHttpMessagesAsync(AssetSettings settings = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> AssetSettingsExistsWithHttpMessagesAsync(string assetId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetSettings>> AssetSettingsGetWithHttpMessagesAsync(string assetId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> AssetSettingsRemoveWithHttpMessagesAsync(string assetId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<AssetSettings>> AssetSettingsGetDefaultWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<string>>> ClientGetAssetIdsWithHttpMessagesAsync(string clientId, bool isIosDevice, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> ClientIsAllowedMakeSwiftDepositWithHttpMessagesAsync(string clientId, bool isIosDevice,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> ClientIsAllowedToCashInViaBankCardWithHttpMessagesAsync(string clientId, bool isIosDevice,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<AssetConditionModel>>> ClientGetAssetConditionsWithHttpMessagesAsync(string clientId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ListOfErc20Token>> Erc20TokenGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> Erc20TokenUpdateWithHttpMessagesAsync(Erc20Token token = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Erc20Token>> Erc20TokenAddWithHttpMessagesAsync(Erc20Token token = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Asset>> Erc20TokenCreateAssetWithHttpMessagesAsync(string address, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ListOfErc20Token>> Erc20TokenGetAllWithAssetsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Erc20Token>> Erc20TokenGetByAddressWithHttpMessagesAsync(string address, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ListOfErc20Token>> Erc20TokenGetBySpecificationWithHttpMessagesAsync(Erc20TokenSpecification specification = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<object>> IsAliveWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<Issuer>>> IssuerGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> IssuerUpdateWithHttpMessagesAsync(Issuer issuer = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Issuer>> IssuerAddWithHttpMessagesAsync(Issuer issuer = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> IssuerExistsWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Issuer>> IssuerGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> IssuerRemoveWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<Issuer>> IssuerGetDefaultWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<MarginAssetPair>>> MarginAssetPairGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> MarginAssetPairUpdateWithHttpMessagesAsync(MarginAssetPair assetCategory = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<MarginAssetPair>> MarginAssetPairAddWithHttpMessagesAsync(MarginAssetPair marginAssetPair = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> MarginAssetPairExistsWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<MarginAssetPair>> MarginAssetPairGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> MarginAssetPairRemoveWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<MarginAssetPair>> MarginAssetPairGetDefaultWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<MarginAsset>>> MarginAssetGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> MarginAssetUpdateWithHttpMessagesAsync(MarginAsset assetCategory = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<MarginAsset>> MarginAssetAddWithHttpMessagesAsync(MarginAsset marginAsset = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> MarginAssetExistsWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<MarginAsset>> MarginAssetGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> MarginAssetRemoveWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<MarginAsset>> MarginAssetGetDefaultWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<ListOfMarginIssuer>> MarginIssuerGetAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> MarginIssuerUpdateWithHttpMessagesAsync(MarginIssuer marginIssuer = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> MarginIssuerAddWithHttpMessagesAsync(MarginIssuer marginIssuer = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<bool?>> MarginIssuerExistsWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<MarginIssuer>> MarginIssuerGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> MarginIssuerRemoveWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<MarginIssuer>> MarginIssuerGetDefaultWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<WatchList>>> WatchListGetAllCustomWithHttpMessagesAsync(string userId = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> WatchListUpdateCustomWithHttpMessagesAsync(WatchList watchList = null, string userId = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<WatchList>> WatchListAddCustomWithHttpMessagesAsync(WatchList watchList = null, string userId = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<WatchList>>> WatchListGetAllPredefinedWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> WatchListUpdatePredefinedWithHttpMessagesAsync(WatchList watchList = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<WatchList>> WatchListAddPredefinedWithHttpMessagesAsync(WatchList watchList = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<WatchList>> WatchListGetCustomWithHttpMessagesAsync(string watchListId, string userId = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> WatchListCustomRemoveWithHttpMessagesAsync(string watchListId, string userId = null,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<IList<WatchList>>> WatchListGetAllWithHttpMessagesAsync(string userId = null, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse<WatchList>> WatchListGetPredefinedWithHttpMessagesAsync(string watchListId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> WatchListRemovePredefinedWithHttpMessagesAsync(string watchListId, Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Uri BaseUri { get; set; }
        public JsonSerializerSettings SerializationSettings { get; }
        public JsonSerializerSettings DeserializationSettings { get; }
    }


}
