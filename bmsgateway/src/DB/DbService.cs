
using System.Data;
using Dapper;
using Npgsql;

namespace bmsgateway.DB
{

    public class DbService : IDbService
    {
        private readonly IDbConnection _db;

        public DbService(IConfiguration configuration)
        {
            _db = new NpgsqlConnection(configuration.GetConnectionString("bmsdb"));
        }
        public async Task<int> EditData(string command, object parms)
        {
             int result;
             result = await _db.ExecuteAsync(command, parms);
              return result;
        }

        public async Task<List<T>> GetAll<T>(string command, object parms)
        {
            List<T> results;
            results = (await _db.QueryAsync<T>(command,parms)).ToList();
            return results;
        }

        public async Task<T> GetAsync<T>(string command, object parms)
        {
            T result;
            result=  (await _db.QueryAsync<T>(command, parms).ConfigureAwait(false))
                          .FirstOrDefault();
            return result;
            
        }
    }

}