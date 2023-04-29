using SeLigaRecife.Web.Entities;

namespace SeLigaRecife.Web.ViewModel;

public class PointsViewModel
{
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public int AlterTypeAsInt { get; set; }

    public static implicit operator Point(PointsViewModel model)
    {
        return new Point()
        {
            CreatedAt = DateTime.Now,
            Latitude = model.Latitude,
            Longitude = model.Longitude,
            Type = (PointType)model.AlterTypeAsInt,
        };
    }
}