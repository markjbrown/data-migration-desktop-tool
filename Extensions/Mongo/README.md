# Mongo Extension

The Mongo data transfer extension provides source and sink capabilities for reading from and writing to a Mongo database.

> **Note**: When specifying the Mongo extension as the Source or Sink property in configuration, utilize the name **Mongo**.
> 
## Settings

Source and sink settings require both `ConnectionString` and `DatabaseName` parameters. The source takes an optional `Collection` parameter (if this parameter is not set, it will read from all collections). The sink requires the `Collection` parameter and will insert all records received from a source into that collection, as well as an optional `BatchSize` parameter (default value is 100) to batch the writes into the collection.

### Source

```json
{
    "ConnectionString": "",
    "DatabaseName: "",
    "Collection": ""
}
```

### Sink

```json
{
    "ConnectionString": "",
    "DatabaseName: "",
    "Collection": "",
    "BatchSize: 100
}
```
