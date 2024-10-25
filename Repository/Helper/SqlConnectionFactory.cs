using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Helper
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection createConnectionAsync();
        IDbConnection createConnection(string conName);
        void closeConnection(string conName);
    }
    public class SqlConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly string _connectionString;
        private readonly string _connectionString2;
        private readonly string _connectionString3;
        private readonly IConfiguration _connectionConfig;
        private static readonly string Server = "Server=";
        private static readonly string DataBase = ";Database=";
        private static readonly string UserId = ";User ID=";
        private static readonly string Password = ";Password=";
        private static readonly string MinPoolSize = "; Min Pool Size=";
        private static readonly string MaxPoolSize = "; Max Pool Size=";
        private static readonly string Pooling = "; Pooling=";
        private static readonly string Timeout = ";Connection Timeout=";


        public SqlConnectionFactory(IConfiguration _connections)
        {

            _connectionConfig = _connections;
        }

        public IDbConnection createConnectionAsync()
        {
            {
                var conSt = new SqlConnectionStringBuilder(_connectionString);
                string strUserId = conSt.UserID;
                string strPassword = conSt.Password;
                string strIP = conSt.DataSource;
                string strDb = conSt.InitialCatalog;
                int strMinPoolSize = conSt.MinPoolSize;
                int strMaxPoolSize = conSt.MaxPoolSize;
                bool strPool = conSt.Pooling;
                string result = Server + strIP + DataBase + strDb + UserId + strUserId + Password + strPassword + MinPoolSize + strMinPoolSize + "" + MaxPoolSize + strMaxPoolSize + "" + Pooling + strPool + "";

                var sqlConnection = new SqlConnection(result);
                sqlConnection.OpenAsync();
                return sqlConnection;
            }
        }

        public IDbConnection createConnection(string conName)
        {

            {
                var conSt = new SqlConnectionStringBuilder(_connectionConfig.GetRequiredSection(conName).Value);
                string strUserId = conSt.UserID;
                string strPassword = conSt.Password;
                string strIP = conSt.DataSource;
                string strDb = conSt.InitialCatalog;
                int strMinPoolSize = conSt.MinPoolSize;
                int strMaxPoolSize = conSt.MaxPoolSize;
                bool strPool = conSt.Pooling;
                int strTimeout = conSt.ConnectTimeout;
                string result = Server + strIP + DataBase + strDb + UserId + strUserId + Password + strPassword + MinPoolSize + strMinPoolSize + "" + MaxPoolSize + strMaxPoolSize + "" + Pooling + strPool + "";

                var sqlConnection = new SqlConnection(result);
                sqlConnection.Open();
                return sqlConnection;
            }

        }

        public void closeConnection(string conName) => createConnection(conName).Dispose();
    }
}