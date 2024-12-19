using Microsoft.Data.SqlClient;
using Shared.Model;
using System.Data;
using Dapper;
using Shared.Model.DTO;

namespace Shared.Service
{
    public class dsMedicamento
    {
        private readonly string _connectionString;

        public dsMedicamento(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task<int> addService(dtoMedicamento medicamento)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("insert into Medicamento(Descripcion,Presentacion,Marca,Estado) Values (@Descripcion,@Presentacion,@Marca,@Estado)", medicamento);
                return res;
            }
        }

        public async Task<int> deleteService(cMedicamento medicamento)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("delete from Medicamento Where IdMedicamento = @id", new { id = medicamento.idmedicamento });
                return res;
            }
        }

        public async Task<cMedicamento> getServiceById(int Id)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.QueryFirstOrDefaultAsync<cMedicamento>("select * from Medicamento Where IdMedicamento = @id", new { id = Id });
                return res;
            }
        }

        public async Task<List<cMedicamento>> getServicelist()
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.QueryAsync<cMedicamento>("Select * from Medicamento");
                return res.ToList();
            }
        }

        public async Task<int> updateService(cMedicamento medicamento)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("update Medicamento Set Descripcion = @Descripcion,Presentacion = @Presentacion,Marca = @Marca,Estado = @Estado Where IdMedicamento = @IdMedicamento", medicamento);
                return res;
            }
        }
    }
}
