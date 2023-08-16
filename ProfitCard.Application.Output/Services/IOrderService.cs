using ProfitCard.Application.Output.Output.ViewModel;

namespace ProfitCard.Application.Output.Services
{
    public interface IOrderService
    {
        Task<OrderViewlModel> GetOrderAsync(string order);

    }
}
