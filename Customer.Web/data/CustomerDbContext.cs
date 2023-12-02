using Dapper;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

namespace Customer.Web.data
{
    public class CustomerDbContext
    {
        private IConfiguration _config;
        private string _connectStr;
        private IDbConnection _db;
        public CustomerDbContext(IConfiguration config)
        {
            _config= config;
            _connectStr = _config.GetConnectionString("constr");
        }
        public IEnumerable<T> Query<T>(string sql)
        {
            _db = new OracleConnection(_connectStr);
            return (_db.Query<T>(sql));
        }
        public T QuerySing<T>(string sql)
        {
            _db = new OracleConnection(_connectStr);
            return (_db.QuerySingle<T>(sql));
        }
    }
}
