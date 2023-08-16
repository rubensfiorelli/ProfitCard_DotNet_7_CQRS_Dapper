using MySqlConnector;
using System.Data;

namespace ProfitCard.Data.Factory
{
    public class SqlFactory
    {
        public IDbConnection MySqlConnection()
        {
            return new MySqlConnection("Server=localhost;Database=ProFitCard;Uid=root;Pwd=Master77$$");
        }
    }
}
