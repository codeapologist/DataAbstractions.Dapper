using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DataAbstractions.Dapper
{
    public interface IGridReader
    {
        /// <summary>
        /// Read the next grid of results, returned as a dynamic object.
        /// </summary>
        /// <param name="buffered">Whether the results should be buffered in memory.</param>
        /// <remarks>Note: each row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        IEnumerable<dynamic> Read(bool buffered = true);

        /// <summary>
        /// Read an individual row of the next grid of results, returned as a dynamic object.
        /// </summary>
        /// <remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        dynamic ReadFirst();

        /// <summary>
        /// Read an individual row of the next grid of results, returned as a dynamic object.
        /// </summary>
        /// <remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        dynamic ReadFirstOrDefault();

        /// <summary>
        /// Read an individual row of the next grid of results, returned as a dynamic object.
        /// </summary>
        /// <remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        dynamic ReadSingle();

        /// <summary>
        /// Read an individual row of the next grid of results, returned as a dynamic object.
        /// </summary>
        /// <remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        dynamic ReadSingleOrDefault();

        /// <summary>
        /// Read the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        /// <param name="buffered">Whether the results should be buffered in memory.</param>
        IEnumerable<T> Read<T>(bool buffered = true);

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        T ReadFirst<T>();

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        T ReadFirstOrDefault<T>();

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        T ReadSingle<T>();

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        T ReadSingleOrDefault<T>();

        /// <summary>
        /// Read the next grid of results.
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <param name="buffered">Whether to buffer the results.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        IEnumerable<object> Read(Type type, bool buffered = true);

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        object ReadFirst(Type type);


        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        object ReadFirstOrDefault(Type type);


        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        object ReadSingle(Type type);


        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        object ReadSingleOrDefault(Type type);

        /// <summary>
        /// Read multiple objects from a single record set on the grid.
        /// </summary>
        /// <typeparam name="TFirst">The first type in the record set.</typeparam>
        /// <typeparam name="TSecond">The second type in the record set.</typeparam>
        /// <typeparam name="TReturn">The type to return from the record set.</typeparam>
        /// <param name="func">The mapping function from the read types to the return type.</param>
        /// <param name="splitOn">The field(s) we should split and read the second object from (defaults to "id")</param>
        /// <param name="buffered">Whether to buffer results in memory.</param>
        IEnumerable<TReturn> Read<TFirst, TSecond, TReturn>(Func<TFirst, TSecond, TReturn> func, string splitOn = "id", bool buffered = true);


        /// <summary>
        /// Read multiple objects from a single record set on the grid.
        /// </summary>
        /// <typeparam name="TFirst">The first type in the record set.</typeparam>
        /// <typeparam name="TSecond">The second type in the record set.</typeparam>
        /// <typeparam name="TThird">The third type in the record set.</typeparam>
        /// <typeparam name="TReturn">The type to return from the record set.</typeparam>
        /// <param name="func">The mapping function from the read types to the return type.</param>
        /// <param name="splitOn">The field(s) we should split and read the second object from (defaults to "id")</param>
        /// <param name="buffered">Whether to buffer results in memory.</param>
        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TReturn>(Func<TFirst, TSecond, TThird, TReturn> func, string splitOn = "id", bool buffered = true);


        /// <summary>
        /// Read multiple objects from a single record set on the grid
        /// </summary>
        /// <typeparam name="TFirst">The first type in the record set.</typeparam>
        /// <typeparam name="TSecond">The second type in the record set.</typeparam>
        /// <typeparam name="TThird">The third type in the record set.</typeparam>
        /// <typeparam name="TFourth">The fourth type in the record set.</typeparam>
        /// <typeparam name="TReturn">The type to return from the record set.</typeparam>
        /// <param name="func">The mapping function from the read types to the return type.</param>
        /// <param name="splitOn">The field(s) we should split and read the second object from (defaults to "id")</param>
        /// <param name="buffered">Whether to buffer results in memory.</param>
        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TReturn> func, string splitOn = "id", bool buffered = true);


        /// <summary>
        /// Read multiple objects from a single record set on the grid
        /// </summary>
        /// <typeparam name="TFirst">The first type in the record set.</typeparam>
        /// <typeparam name="TSecond">The second type in the record set.</typeparam>
        /// <typeparam name="TThird">The third type in the record set.</typeparam>
        /// <typeparam name="TFourth">The fourth type in the record set.</typeparam>
        /// <typeparam name="TFifth">The fifth type in the record set.</typeparam>
        /// <typeparam name="TReturn">The type to return from the record set.</typeparam>
        /// <param name="func">The mapping function from the read types to the return type.</param>
        /// <param name="splitOn">The field(s) we should split and read the second object from (defaults to "id")</param>
        /// <param name="buffered">Whether to buffer results in memory.</param>
        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> func, string splitOn = "id", bool buffered = true);


        /// <summary>
        /// Read multiple objects from a single record set on the grid
        /// </summary>
        /// <typeparam name="TFirst">The first type in the record set.</typeparam>
        /// <typeparam name="TSecond">The second type in the record set.</typeparam>
        /// <typeparam name="TThird">The third type in the record set.</typeparam>
        /// <typeparam name="TFourth">The fourth type in the record set.</typeparam>
        /// <typeparam name="TFifth">The fifth type in the record set.</typeparam>
        /// <typeparam name="TSixth">The sixth type in the record set.</typeparam>
        /// <typeparam name="TReturn">The type to return from the record set.</typeparam>
        /// <param name="func">The mapping function from the read types to the return type.</param>
        /// <param name="splitOn">The field(s) we should split and read the second object from (defaults to "id")</param>
        /// <param name="buffered">Whether to buffer results in memory.</param>
        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> func, string splitOn = "id", bool buffered = true);


        /// <summary>
        /// Read multiple objects from a single record set on the grid
        /// </summary>
        /// <typeparam name="TFirst">The first type in the record set.</typeparam>
        /// <typeparam name="TSecond">The second type in the record set.</typeparam>
        /// <typeparam name="TThird">The third type in the record set.</typeparam>
        /// <typeparam name="TFourth">The fourth type in the record set.</typeparam>
        /// <typeparam name="TFifth">The fifth type in the record set.</typeparam>
        /// <typeparam name="TSixth">The sixth type in the record set.</typeparam>
        /// <typeparam name="TSeventh">The seventh type in the record set.</typeparam>
        /// <typeparam name="TReturn">The type to return from the record set.</typeparam>
        /// <param name="func">The mapping function from the read types to the return type.</param>
        /// <param name="splitOn">The field(s) we should split and read the second object from (defaults to "id")</param>
        /// <param name="buffered">Whether to buffer results in memory.</param>
        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> func, string splitOn = "id", bool buffered = true);


        /// <summary>
        /// Read multiple objects from a single record set on the grid
        /// </summary>
        /// <typeparam name="TReturn">The type to return from the record set.</typeparam>
        /// <param name="types">The types to read from the result set.</param>
        /// <param name="map">The mapping function from the read types to the return type.</param>
        /// <param name="splitOn">The field(s) we should split and read the second object from (defaults to "id")</param>
        /// <param name="buffered">Whether to buffer results in memory.</param>
        IEnumerable<TReturn> Read<TReturn>(Type[] types, Func<object[], TReturn> map, string splitOn = "id", bool buffered = true);



        /// <summary>
        /// Has the underlying reader been consumed?
        /// </summary>
        bool IsConsumed { get; }

        /// <summary>
        /// The command associated with the reader
        /// </summary>
        IDbCommand Command { get; set; }


        /// <summary>
        /// Dispose the grid, closing and disposing both the underlying reader and command.
        /// </summary>
        void Dispose();

        //Async methods

        /// <summary>
        /// Read the next grid of results, returned as a dynamic object
        /// </summary>
        /// <remarks>Note: each row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        /// <param name="buffered">Whether to buffer the results.</param>
        Task<IEnumerable<dynamic>> ReadAsync(bool buffered = true);

        /// <summary>
        /// Read an individual row of the next grid of results, returned as a dynamic object
        /// </summary>
        /// <remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        Task<dynamic> ReadFirstAsync();

        /// <summary>
        /// Read an individual row of the next grid of results, returned as a dynamic object
        /// </summary>
        /// <remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        Task<dynamic> ReadFirstOrDefaultAsync();

        /// <summary>
        /// Read an individual row of the next grid of results, returned as a dynamic object
        /// </summary>
        /// <remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        Task<dynamic> ReadSingleAsync();

        /// <summary>
        /// Read an individual row of the next grid of results, returned as a dynamic object
        /// </summary>
        /// <remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
        Task<dynamic> ReadSingleOrDefaultAsync();

        /// <summary>
        /// Read the next grid of results
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <param name="buffered">Whether to buffer the results.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        Task<IEnumerable<object>> ReadAsync(Type type, bool buffered = true);

        /// <summary>
        /// Read an individual row of the next grid of results
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        Task<object> ReadFirstAsync(Type type);

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        Task<object> ReadFirstOrDefaultAsync(Type type);

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        Task<object> ReadSingleAsync(Type type);

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <param name="type">The type to read.</param>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        Task<object> ReadSingleOrDefaultAsync(Type type);

        /// <summary>
        /// Read the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        /// <param name="buffered">Whether the results should be buffered in memory.</param>
        Task<IEnumerable<T>> ReadAsync<T>(bool buffered = true);

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        Task<T> ReadFirstAsync<T>();

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        Task<T> ReadFirstOrDefaultAsync<T>();

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        Task<T> ReadSingleAsync<T>();

        /// <summary>
        /// Read an individual row of the next grid of results.
        /// </summary>
        /// <typeparam name="T">The type to read.</typeparam>
        Task<T> ReadSingleOrDefaultAsync<T>();
    }
}
