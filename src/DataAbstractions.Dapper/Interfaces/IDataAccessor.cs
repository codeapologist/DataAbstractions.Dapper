using System.Data;

namespace DataAbstractions.Dapper
{
    public partial interface IDataAccessor : IDbConnection
    {
        IDbConnection GetUnderlyingConnection();

        IDataReaderAccessor GetDataReaderAbstraction(IDataReader reader);
    }


}

