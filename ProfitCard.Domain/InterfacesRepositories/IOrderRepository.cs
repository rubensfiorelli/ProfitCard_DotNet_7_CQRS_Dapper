using ProfitCard.Domain.Entities;

namespace ProfitCard.Domain.InterfacesRepositories
{
    public interface IOrderRepository : IUnitOfWork
    {
        Task<Order> GetOrderAsync(string order);
        Task AddAsync(Order order);

    }
}
