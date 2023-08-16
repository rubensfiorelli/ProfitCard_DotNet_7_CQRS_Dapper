using Dapper;
using ProfitCard.Data.Factory;
using ProfitCard.Data.Queries;
using ProfitCard.Domain.Entities;
using ProfitCard.Domain.InterfacesRepositories;
using System.Data;

namespace ProfitCard.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection _connection;

        public CategoryRepository(SqlFactory factory)
        {
            _connection = factory.MySqlConnection();
        }

        public void AddAsync(Category category)
        {
            var query = new CategoryQuery().InsertCategoryQuery(category);
            using (_connection)
            {
                _connection.Execute(query.Query, query.Parameters);
            }
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
