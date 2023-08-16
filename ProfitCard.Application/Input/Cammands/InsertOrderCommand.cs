using ProfitCard.Application.Input.Cammands.Interfaces;
using ProfitCard.Application.Input.InputModels;

namespace ProfitCard.Application.Input.Cammands
{
    public class InsertOrderCommand : ICommandBase
    {
        public Guid ClienteId { get; set; }
        public string Description { get; set; }
        public double ServiceFee { get; set; }
        public DeliveryAdressInputModel DeliveryAddress { get; set; }
    }
}
