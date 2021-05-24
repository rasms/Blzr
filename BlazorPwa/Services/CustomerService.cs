using BlzrModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPwa.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll();
    }

    public class CustomerService : ICustomerService
    {
        private IHttpService _httpService;

        public CustomerService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _httpService.Get<IEnumerable<Customer>>("/Customer");
        }
    }
}