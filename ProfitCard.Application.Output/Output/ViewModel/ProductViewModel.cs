using ProfitCard.Application.Output.Output.Results;
using ProfitCard.Domain.Entities;

namespace ProfitCard.Application.Output.Output.ViewModel
{
    public record ProductViewModel
    {
        public ProductViewModel(Guid id,
                                string title,
                                string description,
                                double benfitValue,
                                double fixedPriceCard,
                                Guid categoryId)
        {
            Id = id;
            Title = title;
            Description = description;
            BenfitValue = benfitValue;
            FixedPriceCard = fixedPriceCard;
            CategoryId = categoryId;
        }

        public Guid Id { get; private init; }
        public string Title { get; private init; }
        public string Description { get; private init; }
        public double BenfitValue { get; private init; }
        public double FixedPriceCard { get; private init; }
        public Guid CategoryId { get; private init; }
        public Result? Result { get; set; }



        public static ProductViewModel FromEntity(Product product)
        {
            return new ProductViewModel(
                product.Id,
                product.Title,
                product.Description,
                product.BenfitValue,
                product.FixedPriceCard,
                product.CategoryId);
        }

    }
}
