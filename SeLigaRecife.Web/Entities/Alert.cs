namespace SeLigaRecife.Web.Entities;

public class Alert : EntityBase
{
    public string FullAddress { get; set; }
    public OccurrenceType OccurrenceType { get; set; }

}