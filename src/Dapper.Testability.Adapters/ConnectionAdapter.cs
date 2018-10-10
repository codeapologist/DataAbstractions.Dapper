using System;
using System.Data;

namespace Dapper.Testability.Adapters
{
    public partial class ConnectionAdapter : IConnectionAdapter
    {
        private readonly IDbConnection _connection;

        public ConnectionAdapter(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public IDbConnection GetUnderlyingConnection() => _connection;

        public void Dispose() => _connection.Dispose();
    }
}