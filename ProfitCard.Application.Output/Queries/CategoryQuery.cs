using ProfitCard.Application.Output.Output.ViewModel;
using ProfitCard.Data.Shared;

namespace ProfitCard.Application.Output.Queries
{
    public class CategoryQuery : BaseQuery
    {
        public QueryModel GetAll(CategoryViewModel category)
        {
            Table = Map.GetCategoryTable();
            Query = $@"

            SELECT {Table}
            VALUES(  @Title,
                     @Description,
                     @IsDeleted
                     @CreateAt
                   )";

            Parameters = new
            {
                Title = category.Title,
                Description = category.Description,
                CreateAt = category.CreateAt

            };


            return new QueryModel(Query, Parameters);
        }
    }
}
