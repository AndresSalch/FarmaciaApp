using Shared.Model;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace Shared.Service
{
    public class dsClienteFarmacia
    {
        private readonly string _connectionString;

        public dsClienteFarmacia(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task<int> addService(cClienteFarmacia cliente)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("insert into ClienteFarmacia (Identificacion,Nombre,FechaNacimiento,Telefono,Email,Estado) Values (@Identificacion,@Nombre,@FechaNacimiento,@Telefono,@Email,@Estado)", cliente);
                return res;
            }
        }

        public async Task<int> deleteService(cClienteFarmacia cliente)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("delete from ClienteFarmacia Where Identificacion = @id", new { id = cliente.identificacion });
                return res;
            }
        }

        public async Task<cClienteFarmacia> getServiceById(int Id)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.QueryFirstOrDefaultAsync<cClienteFarmacia>("select * from ClienteFarmacia Where Identificacion = @id", new { id = Id });
                return res;
            }
        }

        public async Task<List<cClienteFarmacia>> getServicelist()
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.QueryAsync<cClienteFarmacia>("Select * from ClienteFarmacia");
                return res.ToList();
            }
        }

        public async Task<int> updateService(cClienteFarmacia cliente)
        {
            using (var conn = CreateConnection())
            {
                var res = await conn.ExecuteAsync("update ClienteFarmacia Set Nombre = @Nombre,FechaNacimiento = @FechaNacimiento,Telefono = @Telefono,Email = @Email,Estado = @Estado Where Identificacion = @Identificacion", cliente);
                return res;
            }
        }

    }
}
