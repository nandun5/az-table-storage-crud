using Azure;
using Azure.Data.Tables;

string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=XXXXXXXXXXXXXXXX;AccountKey=XXXXXXXXXXXXXXXXXXXX;EndpointSuffix=core.windows.net";

TableClient table = new TableClient(ConnectionString, "mytable3");

do
{
    try
    {
        table.UpsertEntity(new MyEntity("1", "a5b97219-0070-4c41-afe4-88e0a6d47ca3") { MyValue2 = "blaoooooo" });
        break;
    }
    catch (RequestFailedException ex) when (ex.ErrorCode == "TableNotFound")
    {
        Console.WriteLine(ex);
        table.CreateIfNotExists();
    }
} while (true);
