using ProfitCard.Domain.Entities;
using ProfitCard.Domain.ValueObjects;

namespace ProfitCard.Application.Input.InputModels
{
    public class ClientInputModel
    {
        public Name Name { get; private set; }
        public string Email { get; private set; }
        public string Company { get; private set; }
        public DateTime Issue { get; private set; }
        public DateTime Validate { get; private set; }
        public double Value { get; private set; }
        public DeliveryAdress DeliveryAdress { get; private set; }
        public Guid ProductId { get; private set; }


        public Client ToEntity()
            => new Client(Name, Email, Company, Issue, Validate, Value, DeliveryAdress, ProductId);
    }
}
