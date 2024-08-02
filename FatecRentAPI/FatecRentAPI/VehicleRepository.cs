using Dapper;

namespace FatecRentAPI
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IDbContext db;

        public VehicleRepository(IDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            using (var conexao = db.GetConnection()) 
            {
                return await conexao.QueryAsync<Vehicle>("SELECT * FROM Vehicle");
            }
        }
    }
}
