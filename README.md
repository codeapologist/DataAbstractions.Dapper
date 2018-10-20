# DataAbstractions.Dapper [![NuGet](https://img.shields.io/nuget/v/DataAbstractions.Dapper.svg)](https://www.nuget.org/packages/DataAbstractions.Dapper/) 
A light abstraction around [Dapper](https://github.com/StackExchange/Dapper)
 and [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib) that also maintains the behavior [IDbConnection](https://docs.microsoft.com/en-us/dotnet/api/system.data.idbconnection). This library facilitates a loosely coupled design and unit testing.
## IDataAccessor Interface

The IDataAccessor interface encapsulates Dapper extension methods.  Just provide the connection to the DataAccessor.

```csharp

IDataAccessor dataAccessor = new DataAccessor(new SqlConnection(connectionString));
        
```
Execute Dapper queries and commands as you would normally.  

```csharp

var person = await dataAccessor.QueryAsync<Person>(sql, new {Id});

 ```

 Note:   The dataAccessor should be disposed appropriately.

## Dapper.Contrib 

IDataAccessor includes the Dapper.Contrib extension methods

```csharp

dataAccessor.Insert(new Person { Name = "John Doe" });

```

## Keeps IDbConnection behavior

IDataAccessor implements IDbConnection, so you can access things like the ConnectionTimeout, ConnectionString, and ConnectionState etc.

If you need access to the actual connection object, use GetUnderlyingConnection(): 

```csharp
IDbConnection connection = dataAccessor.GetUnderlyingConnection();
```