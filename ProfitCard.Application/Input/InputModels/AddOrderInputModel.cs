using ProfitCard.Domain.Entities;

namespace ProfitCard.Application.Input.InputModels
{
    public class AddOrderInputModel
    {
        public Guid ClienteId { get; set; }
        public string Description { get; set; }
        public double ServiceFee { get; set; }
        public DeliveryAdressInputModel DeliveryAddress { get; set; }
        public List<ProductInputModel> Products { get; set; }


        public Order ToEntity()
            => new Order(
                ClienteId,
                Description,
                ServiceFee,
                DeliveryAddress.ToValueObject());

    }
}
