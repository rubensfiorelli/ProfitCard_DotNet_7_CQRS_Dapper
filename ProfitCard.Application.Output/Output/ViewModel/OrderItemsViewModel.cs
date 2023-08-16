using ProfitCard.Application.Output.Output.Results;
using ProfitCard.Domain.Entities;

namespace ProfitCard.Application.Output.Output.ViewModel
{
    public record OrderItemsViewModel
    {
        public OrderItemsViewModel(Guid id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public Guid Id { get; private init; }
        public string Title { get; private init; }
        public double Price { get; private init; }
        public Result? Result { get; set; }



        public static OrderItemsViewModel FromEntity(OrderItems items)
        {
            return new OrderItemsViewModel(items.Id, items.Title, items.Price);
        }
    }
}