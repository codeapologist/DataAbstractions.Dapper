using FluentAssertions;
using System.Data.SqlClient;
using Xunit;

namespace DataAbstractions.Dapper.Tests
{
    public class DataAccessorShould
    {
        private IDataAccessor _dataAccessor;
        public DataAccessorShould()
        {
            _dataAccessor = new DataAccessor(new SqlConnection("Data Source=localhost;Database=TestDb;User ID=sa;Password=t3st#database"));
        }

        [Fact]
        public async void WorkWithQuerySingleAsync()
        {
            var result = await _dataAccessor.QuerySingleAsync<Company>("select * from Company where id = 1", commandType: System.Data.CommandType.Text);
            var expected = new Company { Id = 1, Name = "Mock Company" };
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async void WorkWithExecuteReaderAsync()
        {
            var reader = await _dataAccessor.ExecuteReaderAsync("select * from Company where id = 1");
            var dataReaderAccessor = _dataAccessor.GetDataReaderAbstraction(reader);
            var result = dataReaderAccessor.Parse<Company>();
            var expected = new Company { Id = 1, Name = "Mock Company" };
            result.Should().BeEquivalentTo(expected);
        }
    }
}
