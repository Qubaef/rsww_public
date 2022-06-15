using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shared.DataModels.Transport;

public class TransportData
{
    public int Id { get; set; }
    public int NumberOfPersons { get; set; }
    public Guid OrderId { get; set; }
}

public class TransportDataModel
{
    [BsonId]
    [BsonRepresentation(BsonType.Int32)]
    public int Id { get; set; }

    [BsonElement("From")]
    public string From { get; set; }
    [BsonElement("To")]
    public string To { get; set; }
    [BsonElement("Price")]
    public int Price { get; set; }
    [BsonElement("AvailableSeats")]
    public int AvailableSeats { get; set; }
    [BsonElement("AllSeats")]
    public int AllSeats { get; set; }

    [BsonElement("Date")]
    public DateTime DateTime { get; set; }

    [BsonElement("Type")]
    public TransportType Type { get; set; }


    public int CalculatePrice(int numberOfPersons)
    {
        return (int)(Price * (2.0 - (double)AvailableSeats / AllSeats) * numberOfPersons);
    }
}

public class TransportEvent
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public int TransportId { get; set; }
    public EventType EventType { get; set; }
    public int SeatsReserved { get; set; }
}

public class TransportIdentifier
{
    public int Id { get; set; }
}

public enum TransportType
{
    Bus,
    Train,
    Plane
}

public enum EventType
{
    Reserved,
    Cancelled
}