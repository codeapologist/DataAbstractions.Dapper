using System;
using System.Collections.Generic;
using System.Data;

namespace DataAbstractions.Dapper
{
    public interface IDataReaderAccessor : IDataReader
    {

        IEnumerable<T> Parse<T>();
        IEnumerable<object> Parse(Type type);
        IEnumerable<dynamic> Parse();
        Func<IDataReader, object> GetRowParser(Type type, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false);
        Func<IDataReader, T> GetRowParser<T>(Type concreteType = null, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false);
    }
}
