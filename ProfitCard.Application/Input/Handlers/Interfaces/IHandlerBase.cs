using ProfitCard.Application.Input.Cammands.Interfaces;
using ProfitCard.Application.Output.Output.Results.Interfaces;

namespace ProfitCard.Application.Input.Handlers.Interfaces
{
    public interface IHandlerBase<in T> where T : ICommandBase
    {
        IResultBase Handle(T command);
    }
}
