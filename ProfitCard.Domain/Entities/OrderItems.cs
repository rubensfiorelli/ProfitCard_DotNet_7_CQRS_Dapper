using ProfitCard.Domain.Common;

namespace ProfitCard.Domain.Entities
{
    public sealed class OrderItems : BaseEntity
    {
        public OrderItems(string title, double price) : base()
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public double Price { get; private set; }

    }
}
