using ProfitCard.Application.Input.Cammands.Interfaces;

namespace ProfitCard.Application.Input.Cammands
{
    public class InsertCategoryCommand : ICommandBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
