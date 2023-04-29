using SeLigaRecife.Web.Entities;

namespace SeLigaRecife.Web.ViewModel;

public class PointsViewModel
{
    public string Longitude { get; set; }
    public string Latitude { get; set; }
    public int AlterTypeAsInt { get; set; }

    public static implicit operator Point(PointsViewModel model)
    {
        Point pointForCreate = new()
        {
            CreatedAt = DateTime.Now,
            Type = (PointType)model.AlterTypeAsInt,
        };
        pointForCreate.Latitude = Convert.ToDouble(model.Latitude, System.Globalization.CultureInfo.InvariantCulture);
        pointForCreate.Longitude = Convert.ToDouble(model.Longitude, System.Globalization.CultureInfo.InvariantCulture);

        return pointForCreate;
    }
}