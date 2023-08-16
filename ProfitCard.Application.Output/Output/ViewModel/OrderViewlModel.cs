using ProfitCard.Application.Output.Output.Results;
using ProfitCard.Domain.Entities;

namespace ProfitCard.Application.Output.Output.ViewModel
{
    public record OrderViewlModel
    {
        public OrderViewlModel(Guid id,
                               Guid clientId,
                               string orderNumber,
                               string cardNumber,
                               string description,
                               double serviceFee,
                               bool isDeleted,
                               string fullAddress,
                               double totalPrice)
        {
            Id = id;
            ClientId = clientId;
            OrderNumber = orderNumber;
            CardNumber = cardNumber;
            Description = description;
            ServiceFee = serviceFee;
            IsDeleted = isDeleted;
            FullAddress = fullAddress;
            TotalPrice = totalPrice;
        }

        public Guid Id { get; private init; }
        public Guid ClientId { get; private init; }
        public string OrderNumber { get; private init; }
        public string CardNumber { get; private init; }
        public string Description { get; private init; }
        public double ServiceFee { get; private init; }
        public bool IsDeleted { get; private init; }
        public string FullAddress { get; private init; }
        public double TotalPrice { get; private init; }
        public Result? Result { get; set; }



        public static OrderViewlModel FromEntity(Order order)
        {

            var address = order.DeliveryAddress;

            return new OrderViewlModel(order.Id,
                order.ClientId,
                order.OrderNumber,
                order.CardNumber,
                order.Description,
                order.ServiceFee,
                order.IsDeleted,
                $"{address.Number}, {address.Street}, {address.Complement}, {address.City}, {address.State}, {address.ZipCode}, {address.Country}",
                order.TotalPrice);

        }


    }
}
