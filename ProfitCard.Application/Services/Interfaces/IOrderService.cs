using ProfitCard.Application.Input.InputModels;

namespace ProfitCard.Application.Services.Interfaces
{
    public interface IOrderService
    {
        Task AddAsync(AddOrderInputModel order);

    }
}
