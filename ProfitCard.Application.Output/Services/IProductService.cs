using ProfitCard.Application.Output.Output.ViewModel;

namespace ProfitCard.Application.Output.Services
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetAllAsync();
        Task<ProductViewModel> GetByIdAsync(Guid id);
    }
}
