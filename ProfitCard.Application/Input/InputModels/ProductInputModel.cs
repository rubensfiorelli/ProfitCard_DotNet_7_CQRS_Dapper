using ProfitCard.Domain.Entities;

namespace ProfitCard.Application.Input.InputModels
{
    public class ProductInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double BenfitValue { get; set; }
        public double FixedPriceCard { get; set; }
        public Guid CategoryId { get; set; }


        public Product ToEntity()
            => new Product(Title, Description, BenfitValue, FixedPriceCard, CategoryId);
    }
}