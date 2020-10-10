using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DataAbstractions.Dapper
{
    public partial interface IDataAccessor : IDbConnection
    {

        //Dapper.Contrib methods
        Task<T> GetAsync<T>(dynamic id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        Task<IEnumerable<T>> GetAllAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        Task<int> InsertAsync<T>(T entityToInsert, IDbTransaction transaction = null, int? commandTimeout = null, ISqlAdapter sqlAdapter = null) where T : class;
        Task<bool> UpdateAsync<T>(T entityToUpdate, IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        Task<bool> DeleteAsync<T>(T entityToDelete, IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        Task<bool> DeleteAllAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        T Get<T>(dynamic id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        IEnumerable<T> GetAll<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        long Insert<T>(T entityToInsert, IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        bool Update<T>(T entityToUpdate, IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        bool Delete<T>(T entityToDelete, IDbTransaction transaction = null, int? commandTimeout = null) where T : class;
        bool DeleteAll<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class;

    }


}

