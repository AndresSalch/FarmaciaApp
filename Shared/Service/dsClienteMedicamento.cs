using Microsoft.Data.SqlClient;
using Shared.Model;
using System.Data;
using Dapper;

namespace Shared.Service
{
    public class dsClienteMedicamento
    {
        private readonly string _connectionString;

        public dsClienteMedicamento(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task<int> addService(cClienteMedicamento cliMedicamento)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("insert into ClienteMedicamento (Identificacion,IdMedicamento,Dosis) Values (@Identificacion,@IdMedicamento,@Dosis)", cliMedicamento);
                return res;
            }
        }

        public async Task<int> deleteService(cClienteMedicamento cliMedicamento)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("delete from ClienteMedicamento Where Identificacion = @id", new { id = cliMedicamento.identificacion });
                return res;
            }
        }

        public async Task<cClienteMedicamento> getServiceById(int Id)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.QueryFirstOrDefaultAsync<cClienteMedicamento>("select * from ClienteMedicamento Where Identificacion = @id", new { id = Id });
                return res;
            }
        }

        public async Task<List<cClienteMedicamento>> getServicelist()
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.QueryAsync<cClienteMedicamento>("Select * from ClienteMedicamento");
                return res.ToList();
            }
        }

        public async Task<int> updateService(cClienteMedicamento cliMedicamento)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("update ClienteMedicamento Set IdMedicamento = @IdMedicamento,Dosis = @Dosis Where Identificacion = @Identificacion", cliMedicamento);
                return res;
            }
        }
    }
}
