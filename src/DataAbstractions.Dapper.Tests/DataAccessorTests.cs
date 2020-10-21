using Dapper;
using FluentAssertions;
using System.Data.SqlClient;
using System.Linq;
using Xunit;

namespace DataAbstractions.Dapper.Tests
{
    public class DataAccessorTests
    {
        public DataAccessorTests()
        {
        }

        public IDataAccessor CreateDataAccessor()
        {
            return new DataAccessor(new SqlConnection("Data Source=localhost;Database=TestDb;User ID=sa;Password=t3st#database"));
        }

        [Fact]
        public async void QueryAsyncWorks()
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
        public async void QueryAsyncCmdDefParameterWorks()
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
        public async void QueryFirstAsyncWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QueryFirstAsync("select * from Employee where lastname = @LastName order by id", new { LastName = "Doe" }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(1);
            firstName.Should().Be("John");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QueryFirstAsyncCmdDefParameterWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var definition = new CommandDefinition("select * from Employee where lastname = @LastName order by id", new { LastName = "Doe" }, transaction, null, commandType: System.Data.CommandType.Text, CommandFlags.Buffered, default);

            var result = await dataAccessor.QueryFirstAsync(definition);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(1);
            firstName.Should().Be("John");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QueryFirstOrDefaultAsyncWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QueryFirstOrDefaultAsync("select * from Employee where lastname = @LastName order by id", new { LastName = "Doe" }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(1);
            firstName.Should().Be("John");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QueryFirstOrDefaultAsyncCmdDefParameterWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var definition = new CommandDefinition("select * from Employee where lastname = @LastName order by id", new { LastName = "Doe" }, transaction, null, commandType: System.Data.CommandType.Text, CommandFlags.Buffered, default);

            var result = await dataAccessor.QueryFirstOrDefaultAsync(definition);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(1);
            firstName.Should().Be("John");
            lastName.Should().Be("Doe");
        }


        [Fact]
        public async void QuerySingleOrDefaultAsyncWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QuerySingleOrDefaultAsync("select * from Employee where Id = @Id", new { Id = 2 }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(2);
            firstName.Should().Be("Jane");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QuerySingleOrDefaultAsyncCmdDefParameterWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var definition = new CommandDefinition("select * from Employee where Id = @Id", new { Id = 2 }, transaction, null, commandType: System.Data.CommandType.Text, CommandFlags.Buffered, default);

            var result = await dataAccessor.QuerySingleOrDefaultAsync(definition);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(2);
            firstName.Should().Be("Jane");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QuerySingleAsyncWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QuerySingleAsync("select * from Employee where Id = @Id", new { Id = 2 }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(2);
            firstName.Should().Be("Jane");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QuerySingleAsyncCmdDefParameterWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var definition = new CommandDefinition("select * from Employee where Id = @Id", new { Id = 2 }, transaction, null, commandType: System.Data.CommandType.Text, CommandFlags.Buffered, default);

            var result = await dataAccessor.QuerySingleAsync(definition);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(2);
            firstName.Should().Be("Jane");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QueryFirstAsyncOfTWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QueryFirstAsync<Employee>("select * from Employee where lastname = @LastName order by id", new { LastName = "Doe" }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(1);
            firstName.Should().Be("John");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QueryFirstOrDefaultAsyncOfTWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QueryFirstOrDefaultAsync<Employee>("select * from Employee where lastname = @LastName order by id", new { LastName = "Doe" }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(1);
            firstName.Should().Be("John");
            lastName.Should().Be("Doe");
        }

        [Fact]
        public async void QuerySingleAsyncOfTWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QuerySingleAsync<Employee>("select * from Employee where Id = @Id", new { Id = 2 }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(2);
            firstName.Should().Be("Jane");
            lastName.Should().Be("Doe");
        }


        [Fact]
        public async void QuerySingleOrDefaultAsyncOfTWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QuerySingleOrDefaultAsync<Employee>("select * from Employee where Id = @Id", new { Id = 2 }, transaction, null, commandType: System.Data.CommandType.Text);
            int? id = result.Id;
            string firstName = result.FirstName;
            string lastName = result.LastName;
            id.Should().Be(2);
            firstName.Should().Be("Jane");
            lastName.Should().Be("Doe");
        }
        [Fact]
        public async void QueryAsyncOfTWorks()
        {

            using var dataAccessor = CreateDataAccessor();

            dataAccessor.Open();

            using var transaction = dataAccessor.BeginTransaction();

            var result = await dataAccessor.QueryAsync<Company>("select * from Company where id = @Id", new { Id = 1 }, transaction, null, commandType: System.Data.CommandType.Text);
            var expected = new Company { Id = 1, Name = "Mock Company" };
            result.Should().BeEquivalentTo(expected);

        }



        [Fact]
        public async void ExecuteReaderAsyncWorks()
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
