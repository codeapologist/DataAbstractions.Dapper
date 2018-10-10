# Dapper.Testability.Adapters

## Basic Usage

Create a connection adapter

```csharp

var connectionAdapter = new ConnectionAdapter(new SqlConnection(connectionString));
        
```
Execute Dapper queries and sql commands normally

```

var person = await connectionAdapter.QueryAsync<Person>(sql, new {Id});

 ```