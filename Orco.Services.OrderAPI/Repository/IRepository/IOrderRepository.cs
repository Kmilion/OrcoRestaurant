using Orco.Services.OrderAPI.Models;
using System.Threading.Tasks;

namespace Orco.Services.OrderAPI.Repository.IRepository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader orderHeader);
        Task UpdateOrderPaymentStatus(int orderHeaderId, bool paid);
    }
}
