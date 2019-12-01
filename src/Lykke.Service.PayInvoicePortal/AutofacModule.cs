using System;
using Autofac;
using Common;
using Lykke.Service.Assets.Client;
using Lykke.Service.EmailPartnerRouter.Client;
using Lykke.Service.PayAuth.Client;
using Lykke.Service.PayInternal.Client;
using Lykke.Service.PayInvoice.Client;
using Lykke.Service.PayInvoicePortal.Core.Services;
using Lykke.Service.PayInvoicePortal.Managers;
using Lykke.Service.PayInvoicePortal.RabbitSubscribers;
using Lykke.Service.PayInvoicePortal.Services;
using Lykke.Service.PayInvoicePortal.Settings;
using Lykke.Service.PayMerchant.Client;
using Lykke.Service.PayMock;
using Lykke.Service.PayMock.AssetsService;
using Lykke.Service.PayMock.EmailPartnerRouter;
using Lykke.Service.PayMock.PayAuth;
using Lykke.Service.PayMock.PayInternal;
using Lykke.Service.PayMock.PayMerchant;
using Lykke.Service.PayMock.RateCalculator;
using Lykke.Service.RateCalculator.Client;
using Lykke.SettingsReader;

namespace Lykke.Service.PayInvoicePortal
{
    public class AutofacModule : Module
    {
        private readonly IReloadingManager<AppSettings> _settings;

        public AutofacModule(
            IReloadingManager<AppSettings> settings)
        {
            _settings = settings;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StartupManager>()
                .As<IStartupManager>();

            builder.RegisterType<AssetsServiceMock>()
                .As<IAssetsService>()
                .SingleInstance();
            
            builder.RegisterType<PayInvoiceMock>()
                .As<IPayInvoiceClient>()
                .SingleInstance();
            
            builder.RegisterType<PayAuthClientMock>()
                .As<IPayAuthClient>()
                .SingleInstance();

            builder.RegisterType<PayInternalClientMock>()
                .As<IPayInternalClient>()
                .SingleInstance();

            builder.RegisterType<EmailPartnerRouterClientMock>()
                .As<IEmailPartnerRouterClient>()
                .SingleInstance();

            builder.RegisterType<RateCalculatorClientMock>()
                .As<IRateCalculatorClient>()
                .SingleInstance();

            builder.RegisterType<PayMerchantClientMock>()
                .As<IPayMerchantClient>()
                .SingleInstance();

            builder.RegisterType<RealtimeNotificationsService>()
                .As<IRealtimeNotificationsService>()
                .SingleInstance();

            RegisterRabbitSubscribers(builder);
        }

        private void RegisterRabbitSubscribers(ContainerBuilder builder)
        {
            builder.RegisterType<InvoiceUpdateSubscriber>()
                .AsSelf()
                .As<IStopable>()
                .SingleInstance();
        }
    }
}
