using Dapper;
using FluentAssertions;
using System.Data.SqlClient;
using System.Linq;
using Xunit;

namespace DataAbstractions.Dapper.Tests
{
    public class DataAccessorShould
    {
        public DataAccessorShould()
        {
        }

        public IDataAccessor CreateDataAccessor()
        {
            return new DataAccessor(new SqlConnection("Data Source=localhost;Database=TestDb;User ID=sa;Password=t3st#database"));
        }

        [Fact]
        public async void WorkWithQueryAsync()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QueryAsync("select * from Company where id = @Id", new { Id = 1 }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.ToList().Single().Id;
            string name = result.ToList().Single().Name;
            id.Should().Be(1);
            name.Should().Be("Mock Company");
        }

        [Fact]
        public async void WorkWithQueryAsyncOverload1()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var definition = new CommandDefinition("select * from Company where id = @Id", new { Id = 1 }, transaction, null, commandType: System.Data.CommandType.Text, CommandFlags.Buffered, default);

            var result = await dataAccessor.QueryAsync(definition);
            int? id = result.ToList().Single().Id;
            string name = result.ToList().Single().Name;
            id.Should().Be(1);
            name.Should().Be("Mock Company");
        }



        [Fact]
        public async void WorkWithQueryAsyncOfT()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QueryAsync<Company>("select * from Company where id = @Id", new { Id = 1 }, transaction, null, commandType: System.Data.CommandType.Text);
            var expected = new Company { Id = 1, Name = "Mock Company" };
            result.Should().BeEquivalentTo(expected);

        }

        [Fact]
        public async void WorkWithQuerySingleAsync()
        {

            using var dataAccessor = CreateDataAccessor();
            var result = await dataAccessor.QuerySingleAsync<Company>("select * from Company where id = 1", commandType: System.Data.CommandType.Text);
            var expected = new Company { Id = 1, Name = "Mock Company" };
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async void WorkWithExecuteReaderAsync()
        {
            using var dataAccessor = CreateDataAccessor();
            var reader = await dataAccessor.ExecuteReaderAsync("select * from Company where id = 1");
            var dataReaderAccessor = dataAccessor.GetDataReaderAbstraction(reader);
            var result = dataReaderAccessor.Parse<Company>();
            var expected = new Company { Id = 1, Name = "Mock Company" };
            result.Should().BeEquivalentTo(expected);
        }
    }
}
