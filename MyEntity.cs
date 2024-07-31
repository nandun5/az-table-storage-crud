using Azure;
using Azure.Data.Tables;

internal class MyEntity : ITableEntity
{
    public MyEntity(string partitionKey, string rowKey)
    {
        PartitionKey = partitionKey;
        RowKey = rowKey;
    }
    public string? MyValue { get; set; }

    public string? MyValue2 {get;set;}
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}