# DataAbstractions.Dapper

## Basic Usage

Create a connection adapter

```csharp

var dataAccessor = new DataAccessor(new SqlConnection(connectionString));
        
```
Execute Dapper queries and sql commands normally

```csharp

var person = await dataAccessor.QueryAsync<Person>(sql, new {Id});

 ```