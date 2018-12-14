using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace DataAbstractions.Dapper
{
    public class GridReaderAdapter : IGridReader
    {
        private readonly SqlMapper.GridReader _gridReader;

        public GridReaderAdapter(SqlMapper.GridReader gridReader)
        {
            _gridReader = gridReader;
        }

        public IEnumerable<dynamic> Read(bool buffered = true) => _gridReader.Read(buffered);

        public dynamic ReadFirst() => _gridReader.ReadFirst();

        public dynamic ReadFirstOrDefault() => _gridReader.ReadFirstOrDefault();

        public dynamic ReadSingle() => _gridReader.ReadSingle();

        public dynamic ReadSingleOrDefault() => _gridReader.ReadSingleOrDefault();

        public IEnumerable<T> Read<T>(bool buffered = true) => _gridReader.Read<T>(buffered);

        public T ReadFirst<T>() => _gridReader.ReadFirst<T>();

        public T ReadFirstOrDefault<T>() => _gridReader.ReadFirstOrDefault<T>();

        public T ReadSingle<T>() => _gridReader.ReadSingle<T>();

        public T ReadSingleOrDefault<T>() => _gridReader.ReadSingleOrDefault<T>();

        public IEnumerable<object> Read(Type type, bool buffered = true) => _gridReader.Read(type, buffered);

        public object ReadFirst(Type type) => _gridReader.ReadFirst(type);

        public object ReadFirstOrDefault(Type type) => _gridReader.ReadFirstOrDefault(type);

        public object ReadSingle(Type type) => _gridReader.ReadSingle(type);

        public object ReadSingleOrDefault(Type type) => _gridReader.ReadSingleOrDefault(type);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TReturn>(Func<TFirst, TSecond, TReturn> func,
            string splitOn = "id", bool buffered = true) =>
            _gridReader.Read<TFirst, TSecond, TReturn>(func, splitOn, buffered);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TReturn>(Func<TFirst, TSecond, TThird, TReturn> func,
            string splitOn = "id", bool buffered = true) =>
            _gridReader.Read<TFirst, TSecond, TThird, TReturn>(func, splitOn, buffered);


        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TReturn>(
            Func<TFirst, TSecond, TThird, TFourth, TReturn> func, string splitOn = "id", bool buffered = true) =>
            _gridReader.Read<TFirst, TSecond, TThird, TFourth, TReturn>(func, splitOn, buffered);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> func, string splitOn = "id",
            bool buffered = true) =>
            _gridReader.Read<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(func, splitOn, buffered);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> func, string splitOn = "id",
            bool buffered = true) =>
            _gridReader.Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(func, splitOn, buffered);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> func, string splitOn = "id",
            bool buffered = true) =>
            _gridReader.Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(func, splitOn,
                buffered);

        public IEnumerable<TReturn> Read<TReturn>(Type[] types, Func<object[], TReturn> map, string splitOn = "id",
            bool buffered = true) => _gridReader.Read<TReturn>(types, map, splitOn, buffered);

        public bool IsConsumed => _gridReader.IsConsumed;

        public IDbCommand Command
        {
            get => _gridReader.Command;
            set => _gridReader.Command = value;
        }

        public void Dispose()
        {
            _gridReader.Dispose();
        }

        public async Task<IEnumerable<dynamic>> ReadAsync(bool buffered = true) => await _gridReader.ReadAsync(buffered);

        public async Task<dynamic> ReadFirstAsync() => await _gridReader.ReadFirstAsync();

        public async Task<dynamic> ReadFirstOrDefaultAsync() => await _gridReader.ReadFirstOrDefaultAsync();

        public async Task<dynamic> ReadSingleAsync() => await _gridReader.ReadSingleAsync();

        public async Task<dynamic> ReadSingleOrDefaultAsync() => await _gridReader.ReadSingleOrDefaultAsync();

        public async Task<IEnumerable<object>> ReadAsync(Type type, bool buffered = true) =>
            await _gridReader.ReadAsync(type, buffered);

        public async Task<object> ReadFirstAsync(Type type) => await _gridReader.ReadFirstAsync(type);

        public async Task<object> ReadFirstOrDefaultAsync(Type type) => await _gridReader.ReadFirstOrDefaultAsync(type);

        public async Task<object> ReadSingleAsync(Type type) => await _gridReader.ReadSingleAsync(type);

        public async Task<object> ReadSingleOrDefaultAsync(Type type) =>
            await _gridReader.ReadSingleOrDefaultAsync(type);

        public async Task<IEnumerable<T>> ReadAsync<T>(bool buffered = true) =>
            await _gridReader.ReadAsync<T>(buffered);

        public async Task<T> ReadFirstAsync<T>() => await _gridReader.ReadFirstAsync<T>();

        public async Task<T> ReadFirstOrDefaultAsync<T>() => await _gridReader.ReadFirstOrDefaultAsync<T>();

        public async Task<T> ReadSingleAsync<T>() => await _gridReader.ReadSingleAsync<T>();

        public async Task<T> ReadSingleOrDefaultAsync<T>() => await _gridReader.ReadSingleOrDefaultAsync<T>();

    }
}