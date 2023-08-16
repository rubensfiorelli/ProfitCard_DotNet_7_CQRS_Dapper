using ProfitCard.Domain.Entities;

namespace ProfitCard.Application.Input.InputModels
{
    public class OrderItemsInputModel
    {
        public string Title { get; private set; }
        public double Price { get; private set; }

        public OrderItems ToEntity()
            => new OrderItems(Title, Price);

    }
}
