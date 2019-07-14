using NorthwindWebApiApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindWebApiApp.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<BriefOrderDescription>> GetOrdersAsync();

        Task<FullOrderDescription> GetOrderAsync(int orderId);
    }
}