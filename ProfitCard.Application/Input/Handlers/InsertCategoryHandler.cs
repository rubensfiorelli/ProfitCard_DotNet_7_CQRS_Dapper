using ProfitCard.Application.Input.Cammands;
using ProfitCard.Application.Input.Handlers.Interfaces;
using ProfitCard.Application.Output.Output.Results;
using ProfitCard.Application.Output.Output.Results.Interfaces;
using ProfitCard.Domain.Entities;
using ProfitCard.Domain.InterfacesRepositories;

namespace ProfitCard.Application.Input.Handlers
{
    public class InsertCategoryHandler : IHandlerBase<InsertCategoryCommand>
    {
        protected readonly ICategoryRepository _repository;

        public InsertCategoryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public IResultBase Handle(InsertCategoryCommand command)
        {
            var category = new Category(command.Title, command.Description);
            Result result;

            try
            {
                _repository.AddAsync(category);
                result = new Result(200, "Registro inserido com sucesso", true, category);
                return result;
            }
            catch (Exception)
            {
                _ = new Result(500, "Erro interno no servidor", false, category);
            }
            result = new Result(400, "Falha, verifique os campos e tente novamente", false, category);
            return result;
        }

    }
}
