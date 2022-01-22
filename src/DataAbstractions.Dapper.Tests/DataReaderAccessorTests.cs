using FluentAssertions;
using System.Collections.Generic;
using System.Data.SqlClient;
using Xunit;

namespace DataAbstractions.Dapper.Tests
{
    public class DataReaderAccessorTests
    {
        public DataReaderAccessorTests()
        {
        }

        public IDataAccessor CreateDataAccessor()
        {
            return new DataAccessor(new SqlConnection("Data Source=localhost;Database=TestDb;Integrated Security=True;"));
        }

        [Fact]
        public async void ExecuteReaderAsyncWorks()
        {
            using var dataAccessor = CreateDataAccessor();
            var reader = await dataAccessor.ExecuteReaderAsync("select * from Company where id = 1");
            var dataReaderAccessor = dataAccessor.GetDataReaderAccessor(reader);
            var result = dataReaderAccessor.Parse<Company>();
            var expected = new List<Company> { new Company { Id = 1, Name = "Mock Company" } };
            result.Should().BeEquivalentTo(expected);
        }
    }
}
