using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Dapper.Testability.Adapters
{
    //This partial class is reserved for the Dapper.Contrib implementation
    public partial class ConnectionAdapter
    {
        public Task<T> GetAsync<T>(dynamic id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            SqlMapperExtensions.GetAsync<T>(_connection, id, transaction, commandTimeout);

        public Task<IEnumerable<T>> GetAllAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.GetAllAsync<T>(transaction, commandTimeout);

        public Task<int> InsertAsync<T>(T entityToInsert, IDbTransaction transaction = null, int? commandTimeout = null, ISqlAdapter sqlAdapter = null) where T : class =>
            _connection.InsertAsync(entityToInsert, transaction, commandTimeout, sqlAdapter);

        public Task<bool> UpdateAsync<T>(T entityToUpdate, IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.UpdateAsync(entityToUpdate, transaction, commandTimeout);

        public Task<bool> DeleteAsync<T>(T entityToDelete, IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.DeleteAsync(entityToDelete, transaction, commandTimeout);

        public Task<bool> DeleteAllAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.DeleteAllAsync<T>(transaction, commandTimeout);

        public T Get<T>(dynamic id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            SqlMapperExtensions.Get<T>(_connection, id, transaction, commandTimeout);

        public IEnumerable<T> GetAll<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.GetAll<T>(transaction, commandTimeout);

        public long Insert<T>(T entityToInsert, IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.Insert(entityToInsert, transaction, commandTimeout);

        public bool Update<T>(T entityToUpdate, IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.Update(entityToUpdate, transaction, commandTimeout);

        public bool Delete<T>(T entityToDelete, IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.Delete(entityToDelete, transaction, commandTimeout);

        public bool DeleteAll<T>(IDbTransaction transaction = null, int? commandTimeout = null) where T : class =>
            _connection.DeleteAll<T>(transaction, commandTimeout);
    }
}
