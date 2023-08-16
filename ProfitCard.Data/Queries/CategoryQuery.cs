using ProfitCard.Data.Shared;
using ProfitCard.Domain.Entities;

namespace ProfitCard.Data.Queries
{
    public class CategoryQuery : BaseQuery
    {
        public QueryModel InsertCategoryQuery(Category category)
        {
            Table = Map.GetCategoryTable();
            Query = $@"

            INSERT INTO{Table}
            VALUES(  @Title,
                     @Description,
                     @IsDeleted
                     @CreateAt
                   )";

            Parameters = new
            {
                Title = category.Title,
                Description = category.Description,
                IsDeleted = category.IsDeleted,
                CreateAt = category.CreateAt

            };


            return new QueryModel(Query, Parameters);
        }
    }
}
