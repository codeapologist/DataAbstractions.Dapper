using System.Data;

namespace Dapper.Testability.Adapters
{
    //This partial class is reserved for the IDbConnection implementation
    public partial class ConnectionAdapter
    {
        public string ConnectionString
        {
            get => _connection.ConnectionString;
            set => _connection.ConnectionString = value;
        }

        public int ConnectionTimeout => _connection.ConnectionTimeout;

        public string Database => _connection.Database;

        public ConnectionState State => _connection.State;

        public IDbTransaction BeginTransaction() => _connection.BeginTransaction();

        public IDbTransaction BeginTransaction(IsolationLevel il) => _connection.BeginTransaction(il);

        public void Close() => _connection.Close();

        public void ChangeDatabase(string databaseName) => _connection.ChangeDatabase(databaseName);

        public IDbCommand CreateCommand() => _connection.CreateCommand();

        public void Open() => _connection.Open();
    }
}
