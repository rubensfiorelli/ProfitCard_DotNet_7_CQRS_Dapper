using ProfitCard.Application.Input.InputModels;

namespace ProfitCard.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task AddAsync(CategoryInputModel category);

    }
}
