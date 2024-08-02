using System.Data;

namespace FatecRentAPI
{
    public interface IDbContext
    {
        IDbConnection GetConnection();
    }
}
