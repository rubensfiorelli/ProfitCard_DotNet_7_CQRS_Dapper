using ProfitCard.Application.Output.Output.ViewModel;

namespace ProfitCard.Application.Output.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAllAsync();
        Task<CategoryViewModel> GetByIdAsync(Guid id);

    }
}
