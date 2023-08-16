using ProfitCard.Domain.Common;

namespace ProfitCard.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public Product(string title,
            string description,
            double benfitValue,
            double fixedPriceCard,
            Guid categoryId) : base()
        {
            Title = title;
            Description = description;
            BenfitValue = benfitValue;
            FixedPriceCard = fixedPriceCard;
            CategoryId = categoryId;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public double BenfitValue { get; private set; }
        public double FixedPriceCard { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category? Category { get; private set; }
    }
}
