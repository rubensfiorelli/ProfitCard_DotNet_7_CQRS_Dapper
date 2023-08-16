using ProfitCard.Domain.ValueObjects;

namespace ProfitCard.Application.Input.InputModels
{
    public class NameInputModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Name ToValueObject()
            => new Name(FirstName, LastName);
    }
}
