using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.PayInvoice.Client.Models.Employee;

namespace Lykke.Service.PayMock
{
    public partial class PayInvoiceMock
    {
        public Task<IReadOnlyList<EmployeeModel>> GetEmployeesAsync(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<EmployeeModel>> GetEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeModel> GetEmployeeAsync(string employeeId)
        {
            return new EmployeeModel(){
                MerchantId = DemoData.DemoMerchantId,
                Email = DemoData.DemoEmail,
                FirstName = DemoData.FirstName,
                LastName = DemoData.LastName,
                Id = employeeId
            };
        }

        public Task<EmployeeModel> AddEmployeeAsync(CreateEmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public Task MarkEmployeeDeletedAsync(MarkEmployeeDeletedRequest model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeeAsync(UpdateEmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeeAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetEmployeeByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
