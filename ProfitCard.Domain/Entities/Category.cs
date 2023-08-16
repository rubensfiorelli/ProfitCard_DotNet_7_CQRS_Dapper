using ProfitCard.Domain.Common;

namespace ProfitCard.Domain.Entities
{
    public sealed class Category : BaseEntity
    {
        public Category(string title, string description) : base()
        {
            Title = title;
            Description = description;
            IsDeleted = false;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<Product>? Products { get; set; }

        public void SetCategory(string newTitle, string newDescription)
        {
            Title = newTitle;
            Description = newDescription;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
