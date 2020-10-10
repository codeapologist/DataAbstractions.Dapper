using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAbstractions.Dapper
{

    public partial class GridAccessor
    {
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
