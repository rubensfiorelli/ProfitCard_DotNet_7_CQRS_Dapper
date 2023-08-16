using ProfitCard.Application.Input.InputModels;

namespace ProfitCard.Application.Services.Interfaces
{
    public interface IClientService
    {
        Task AddAsync(ClientInputModel client);

    }
}
