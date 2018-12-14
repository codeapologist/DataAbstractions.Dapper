using System;
using System.Collections.Generic;
using System.Data;

namespace DataAbstractions.Dapper
{
    public partial class GridAccessor
    {
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
            _gridReader.Read(func, splitOn, buffered);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TReturn>(Func<TFirst, TSecond, TThird, TReturn> func,
            string splitOn = "id", bool buffered = true) =>
            _gridReader.Read(func, splitOn, buffered);


        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TReturn>(
            Func<TFirst, TSecond, TThird, TFourth, TReturn> func, string splitOn = "id", bool buffered = true) =>
            _gridReader.Read(func, splitOn, buffered);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> func, string splitOn = "id",
            bool buffered = true) =>
            _gridReader.Read(func, splitOn, buffered);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> func, string splitOn = "id",
            bool buffered = true) =>
            _gridReader.Read(func, splitOn, buffered);

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> func, string splitOn = "id",
            bool buffered = true) =>
            _gridReader.Read(func, splitOn,
                buffered);

        public IEnumerable<TReturn> Read<TReturn>(Type[] types, Func<object[], TReturn> map, string splitOn = "id",
            bool buffered = true) => _gridReader.Read(types, map, splitOn, buffered);

        public bool IsConsumed => _gridReader.IsConsumed;

        public IDbCommand Command
        {
            get => _gridReader.Command;
            set => _gridReader.Command = value;
        }
    }
}
