namespace ProfitCard.Domain.InterfacesRepositories
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();
    }
}
