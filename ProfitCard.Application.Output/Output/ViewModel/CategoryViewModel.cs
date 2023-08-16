using ProfitCard.Application.Output.Output.Results;
using ProfitCard.Domain.Entities;

namespace ProfitCard.Application.Output.Output.ViewModel
{
    public record CategoryViewModel
    {
        public CategoryViewModel(Guid id, string title, string description, DateTime createAt)
        {
            Id = id;
            Title = title;
            Description = description;
            CreateAt = createAt;
        }

        public Guid Id { get; private init; }
        public string Title { get; private init; }
        public string Description { get; private init; }
        public DateTime CreateAt { get; private set; }
        public Result? Result { get; set; }


        public static CategoryViewModel FromEntity(Category category)
        {
            return new CategoryViewModel(
                category.Id,
                category.Title,
                category.Description,
                category.CreateAt);

        }
    }
}
