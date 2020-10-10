using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAbstractions.Dapper
{

    public partial class DataReaderAccessor : IDataReaderAccessor
    {

        //Dapper Extensions
        public IEnumerable<T> Parse<T>()
        {
            return _dataReader.Parse<T>();
        }

        public IEnumerable<object> Parse(Type type)
        {
            return _dataReader.Parse(type);
        }

        public IEnumerable<dynamic> Parse()
        {
            return _dataReader.Parse();
        }

        public Func<IDataReader, object> GetRowParser(Type type, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false)
        {
            return _dataReader.GetRowParser(type, startIndex, length, returnNullIfFirstMissing);
        }

        public Func<IDataReader, T> GetRowParser<T>(Type concreteType = null, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false)
        {
            return _dataReader.GetRowParser<T>(concreteType, startIndex, length, returnNullIfFirstMissing);
        }


    }
}
