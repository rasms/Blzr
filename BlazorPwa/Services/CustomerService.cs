using BlzrModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPwa.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> List();
        Task<Customer> Update(Customer customer);
    }

    public class CustomerService : ICustomerService
    {
        private IHttpService _httpService;

        public CustomerService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<Customer>> List()
        {
            return await _httpService.Get<IEnumerable<Customer>>("/Customer");
        }
        public async Task<Customer> Update(Customer customer)
        {
            return await _httpService. Put<Customer>($"/Customer/{customer.CustomerId}", customer);
        }
    }
}