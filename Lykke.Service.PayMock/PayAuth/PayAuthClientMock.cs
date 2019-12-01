using System.Threading;
using System.Threading.Tasks;
using Lykke.Service.PayAuth.Client;
using Lykke.Service.PayAuth.Client.Models;
using Lykke.Service.PayAuth.Client.Models.Employees;
using Lykke.Service.PayAuth.Client.Models.GenerateRsaKeys;
using Lykke.Service.PayMock.PayAuth.RSA;

namespace Lykke.Service.PayMock.PayAuth
{
    public class PayAuthClientMock : IPayAuthClient
    {
        public async Task RegisterAsync(RegisterRequest request, CancellationToken cancellationToken = new CancellationToken())
        {
            
        }

        public Task UpdateApiKeyAsync(UpdateApiKeyRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PayAuthInformationResponse> GetPayAuthInformationAsync(string merchantId)
        {
            return new PayAuthInformationResponse()
            {
                MerchantId = merchantId,
                ApiKey = DemoRsa.DemoApiKey,
                RsaPublicKey = DemoRsa.DemoPublicKey
            };
        }

        public Task<GenerateRsaKeysResponse> GenerateRsaKeysAsync(GenerateRsaKeysRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SignatureValidationResponse> VerifyAsync(VerifyRequest request, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new System.NotImplementedException();
        }

        public Task RegisterAsync(RegisterModel model, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(UpdateCredentialsModel model, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new System.NotImplementedException();
        }

        public async Task<ValidateResultModel> ValidatePasswordAsync(string email, string password)
        {
            return new ValidateResultModel()
            {
                MerchantId = DemoData.DemoMerchantId,
                EmployeeId = DemoData.DemoEmployeeId,
                ForceEmailConfirmation = false,
                ForcePasswordUpdate = false,
                ForcePinUpdate = false,
                Success = true
            };
        }

        public Task UpdatePasswordHashAsync(UpdatePasswordHashModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task EnforceCredentialsUpdateAsync(EnforceCredentialsUpdateModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task SetEmailConfirmedAsync(EmailConfirmedRequest model)
        {
            return Task.CompletedTask;
        }

        public async Task<ValidateResultModel> ValidatePinAsync(string email, string pin)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdatePinHashAsync(UpdatePinHashModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ResetPasswordTokenModel> CreateResetPasswordTokenAsync(CreateResetPasswordTokenRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResetPasswordTokenModel> GetResetPasswordTokenByPublicIdAsync(string publicId)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResetPasswordTokenModel> RedeemResetPasswordTokenAsync(string publicId)
        {
            throw new System.NotImplementedException();
        }
    }
}
