namespace SeLigaRecife.Web.Entities;

public class Category : EntityBase
{
    public string Name { get; set; }

    public List<OccurrenceType> OccurrenceTypes { get; set; }
}