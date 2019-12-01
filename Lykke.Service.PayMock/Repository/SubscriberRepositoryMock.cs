using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.PayInvoicePortal.Core.Domain;
using Lykke.Service.PayInvoicePortal.Core.Repositories;

namespace Lykke.Service.PayMock.Repository
{
    public class SubscriberRepositoryMock: ISubscriberRepository
    {
        private Dictionary<string, Subscriber> _data = new Dictionary<string, Subscriber>();
        public async Task<Subscriber> GetAsync(string email)
        {
            if (_data.TryGetValue(email, out var subs))
                return subs;

            return null;
        }

        public async Task InsertAsync(Subscriber subscriber)
        {
            _data.Add(subscriber.Email, subscriber);
        }
    }
}
