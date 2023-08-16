using ProfitCard.Application.Output.Output.ViewModel;

namespace ProfitCard.Application.Output.Services
{
    public interface IClientService
    {
        Task<List<ClientViewModel>> GetAllAsync();
        Task<ClientViewModel> GetByIdAsync(Guid id);
    }
}
