using System;
using System.Data;
using System.Data.Common;

namespace DataAbstractions.Dapper
{
    public partial class DataAccessor : IDataAccessor
    {
        private readonly IDbConnection _connection;

        public DataAccessor(DbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public IDbConnection GetUnderlyingConnection() => _connection;

        public IDataReaderAccessor GetDataReaderAbstraction(IDataReader reader)
        {
            return new DataReaderAccessor(reader);
        }

        public void Dispose() => _connection.Dispose();


    }
}