namespace SeLigaRecife.Web.Entities;

public class OccurrenceType : EntityBase
{
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}