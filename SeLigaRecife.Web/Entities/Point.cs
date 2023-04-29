namespace SeLigaRecife.Web.Entities
{
    public class Point : EntityBase
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public PointType Type { get; set; }
    }

    public enum PointType
    {
        Security,
        Danger
    }
}
