using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace DataAbstractions.Dapper
{
    //This partial class is reserved for the Dapper implementation
    public partial class DataAccessor
    {
        public Task<IEnumerable<dynamic>> QueryAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync(sql, param, transaction, commandTimeout, commandType);

        public Task<IEnumerable<dynamic>> QueryAsync(CommandDefinition command) =>
            _connection.QueryAsync(command);

        public Task<dynamic> QueryFirstAsync(CommandDefinition command) =>
            _connection.QueryFirstAsync(command);

        public Task<dynamic> QueryFirstOrDefaultAsync(CommandDefinition command) =>
            _connection.QueryFirstOrDefaultAsync(command);

        public Task<dynamic> QuerySingleAsync(CommandDefinition command) =>
            _connection.QuerySingleAsync(command);

        public Task<dynamic> QuerySingleOrDefaultAsync(CommandDefinition command) =>
            _connection.QuerySingleOrDefaultAsync(command);

        public Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync<T>(sql, param, transaction, commandTimeout, commandType);

        public Task<T> QueryFirstAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstAsync<T>(sql, param, transaction, commandTimeout, commandType);

        public Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction, commandTimeout, commandType);

        public Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleAsync<T>(sql, param, transaction, commandTimeout, commandType);

        public Task<T> QuerySingleOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleOrDefaultAsync<T>(sql, param, transaction, commandTimeout, commandType);

        public Task<dynamic> QueryFirstAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstAsync(sql, param, transaction, commandTimeout, commandType);

        public Task<dynamic> QueryFirstOrDefaultAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstOrDefaultAsync(sql, param, transaction, commandTimeout, commandType);

        public Task<dynamic> QuerySingleAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleAsync(sql, param, transaction, commandTimeout, commandType);

        public Task<dynamic> QuerySingleOrDefaultAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleOrDefaultAsync(sql, param, transaction, commandTimeout, commandType);

        public Task<IEnumerable<object>> QueryAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync(type, sql, param, transaction, commandTimeout, commandType);

        public Task<object> QueryFirstAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstAsync(type, sql, param, transaction, commandTimeout, commandType);

        public Task<object> QueryFirstOrDefaultAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstOrDefaultAsync(type, sql, param, transaction, commandTimeout, commandType);

        public Task<object> QuerySingleAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleAsync(type, sql, param, transaction, commandTimeout, commandType);

        public Task<object> QuerySingleOrDefaultAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleOrDefaultAsync(type, sql, param, transaction, commandTimeout, commandType);

        public Task<IEnumerable<T>> QueryAsync<T>(CommandDefinition command) =>
            _connection.QueryAsync<T>(command);

        public Task<IEnumerable<object>> QueryAsync(Type type, CommandDefinition command) =>
            _connection.QueryAsync(type, command);

        public Task<object> QueryFirstAsync(Type type, CommandDefinition command) =>
            _connection.QueryFirstAsync(type, command);

        public Task<T> QueryFirstAsync<T>(CommandDefinition command) =>
            _connection.QueryFirstAsync<T>(command);

        public Task<object> QueryFirstOrDefaultAsync(Type type, CommandDefinition command) =>
            _connection.QueryFirstOrDefaultAsync(type, command);

        public Task<T> QueryFirstOrDefaultAsync<T>(CommandDefinition command) =>
            _connection.QueryFirstOrDefaultAsync<T>(command);

        public Task<object> QuerySingleAsync(Type type, CommandDefinition command) =>
            _connection.QuerySingleAsync(type, command);

        public Task<T> QuerySingleAsync<T>(CommandDefinition command) =>
            _connection.QuerySingleAsync<T>(command);

        public Task<object> QuerySingleOrDefaultAsync(Type type, CommandDefinition command) =>
            _connection.QuerySingleOrDefaultAsync(type, command);

        public Task<T> QuerySingleOrDefaultAsync<T>(CommandDefinition command) =>
            _connection.QuerySingleOrDefaultAsync<T>(command);

        public Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.ExecuteAsync(sql, param, transaction, commandTimeout, commandType);

        public Task<int> ExecuteAsync(CommandDefinition command) =>
            _connection.ExecuteAsync(command);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
               _connection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TReturn> map, string splitOn = "Id") =>
               _connection.QueryAsync(command, map, splitOn);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TReturn> map, string splitOn = "Id") =>
            _connection.QueryAsync(command, map, splitOn);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, string splitOn = "Id") =>
            _connection.QueryAsync(command, map, splitOn);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, string splitOn = "Id") =>
            _connection.QueryAsync(command, map, splitOn);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, string splitOn = "Id") =>
            _connection.QueryAsync(command, map, splitOn);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, string splitOn = "Id") =>
            _connection.QueryAsync(command, map, splitOn);

        public Task<IEnumerable<TReturn>> QueryAsync<TReturn>(string sql, Type[] types, Func<object[], TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryAsync(sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public async Task<IGridAccessor> QueryMultipleAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
           new GridAccessor( await _connection.QueryMultipleAsync(sql, param, transaction, commandTimeout, commandType));

        public async Task<IGridAccessor> QueryMultipleAsync(CommandDefinition command) =>
            new GridAccessor(await _connection.QueryMultipleAsync(command));

        public Task<IDataReader> ExecuteReaderAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.ExecuteReaderAsync(sql, param, transaction, commandTimeout, commandType);

        public Task<IDataReader> ExecuteReaderAsync(CommandDefinition command) =>
            _connection.ExecuteReaderAsync(command);

        public Task<IDataReader> ExecuteReaderAsync(CommandDefinition command, CommandBehavior commandBehavior) =>
            _connection.ExecuteReaderAsync(command, commandBehavior);

        public Task<object> ExecuteScalarAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.ExecuteScalarAsync(sql, param, transaction, commandTimeout, commandType);

        public Task<T> ExecuteScalarAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.ExecuteScalarAsync<T>(sql, param, transaction, commandTimeout, commandType);

        public Task<object> ExecuteScalarAsync(CommandDefinition command) =>
            _connection.ExecuteScalarAsync(command);

        public Task<T> ExecuteScalarAsync<T>(CommandDefinition command) =>
            _connection.ExecuteScalarAsync<T>(command);

        public int Execute(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Execute(sql, param, transaction, commandTimeout, commandType);

        public int Execute(CommandDefinition command) =>
            _connection.Execute(command);

        public object ExecuteScalar(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.ExecuteScalar(sql, param, transaction, commandTimeout, commandType);

        public T ExecuteScalar<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.ExecuteScalar<T>(sql, param, transaction, commandTimeout, commandType);

        public object ExecuteScalar(CommandDefinition command) =>
            _connection.ExecuteScalar(command);

        public T ExecuteScalar<T>(CommandDefinition command) =>
            _connection.ExecuteScalar<T>(command);

        public IDataReader ExecuteReader(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.ExecuteReader(sql, param, transaction, commandTimeout, commandType);

        public IDataReader ExecuteReader(CommandDefinition command) =>
            _connection.ExecuteReader(command);

        public IDataReader ExecuteReader(CommandDefinition command, CommandBehavior commandBehavior) =>
            _connection.ExecuteReader(command, commandBehavior);

        public IEnumerable<dynamic> Query(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(sql, param, transaction, buffered, commandTimeout, commandType);

        public dynamic QueryFirst(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirst(sql, param, transaction, commandTimeout, commandType);

        public dynamic QueryFirstOrDefault(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstOrDefault(sql, param, transaction, commandTimeout, commandType);

        public dynamic QuerySingle(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingle(sql, param, transaction, commandTimeout, commandType);

        public dynamic QuerySingleOrDefault(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleOrDefault(sql, param, transaction, commandTimeout, commandType);

        public IEnumerable<T> Query<T>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query<T>(sql, param, transaction, buffered, commandTimeout, commandType);

        public T QueryFirst<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirst<T>(sql, param, transaction, commandTimeout, commandType);

        public T QueryFirstOrDefault<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstOrDefault<T>(sql, param, transaction, commandTimeout, commandType);

        public T QuerySingle<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingle<T>(sql, param, transaction, commandTimeout, commandType);

        public T QuerySingleOrDefault<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleOrDefault<T>(sql, param, transaction, commandTimeout, commandType);

        public IEnumerable<object> Query(Type type, string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(type, sql, param, transaction, buffered, commandTimeout, commandType);

        public object QueryFirst(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirst(type, sql, param, transaction, commandTimeout, commandType);

        public object QueryFirstOrDefault(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QueryFirstOrDefault(type, sql, param, transaction, commandTimeout, commandType);

        public object QuerySingle(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingle(type, sql, param, transaction, commandTimeout, commandType);

        public object QuerySingleOrDefault(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.QuerySingleOrDefault(type, sql, param, transaction, commandTimeout, commandType);

        public IEnumerable<T> Query<T>(CommandDefinition command) =>
            _connection.Query<T>(command);

        public T QueryFirst<T>(CommandDefinition command) =>
            _connection.QueryFirst<T>(command);

        public T QueryFirstOrDefault<T>(CommandDefinition command) =>
            _connection.QueryFirstOrDefault<T>(command);

        public T QuerySingle<T>(CommandDefinition command) =>
            _connection.QuerySingle<T>(command);

        public T QuerySingleOrDefault<T>(CommandDefinition command) =>
            _connection.QuerySingleOrDefault<T>(command);

        public IGridAccessor QueryMultiple(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            new GridAccessor(_connection.QueryMultiple(sql, param, transaction, commandTimeout, commandType));

        public IGridAccessor QueryMultiple(CommandDefinition command) =>
            new GridAccessor(_connection.QueryMultiple(command));

        public IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TReturn>(string sql, Type[] types, Func<object[], TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            _connection.Query(sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

    }
}