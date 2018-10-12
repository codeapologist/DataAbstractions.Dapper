# DataAbstractions.Dapper [![NuGet](https://img.shields.io/nuget/v/DataAbstractions.Dapper.svg)](https://www.nuget.org/packages/DataAbstractions.Dapper/) 
A light abstraction around Dapper and Dapper.Contrib that also maintains the behavior IDbConnection. 
## Basic Usage

Create a data accessor

```csharp

IDataAccessor dataAccessor = new DataAccessor(new SqlConnection(connectionString));
        
```
Execute Dapper queries and sql commands normally.  

```csharp

var person = await dataAccessor.QueryAsync<Person>(sql, new {Id});

 ```

 Note:  You need to dispose of the dataAccessor as your would with IDbConnection.

## Dapper.Contrib methods

IDataAccessor includes Dapper.Contrib methods

```csharp

dataAccessor.Insert(new Person { Name = "John Doe" });

```

## IDbConnection methods

IDataAccessor implements IDbConnection, so you can access things like the ConnectionTimeout value.

```csharp

var timeout = dataAccessor.ConnectionTimeout;

```