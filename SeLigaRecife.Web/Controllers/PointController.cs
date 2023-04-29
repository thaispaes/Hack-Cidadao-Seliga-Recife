using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SeLigaRecife.Web.Context;
using SeLigaRecife.Web.Entities;
using SeLigaRecife.Web.ViewModel;

namespace SeLigaRecife.Web.Controllers;

public class PointController : Controller
{
    private readonly SeLigaRecifeDbContext _context;

    public PointController(SeLigaRecifeDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AddPoint([FromBody] PointsViewModel model)
    {
        _context.Points.Add(model);

        return Ok();
    }

    public IActionResult Home()
    {
        return View();
    }

    public IActionResult GetPointsAjaxHandler()
    {
        List<PointsViewModel> poinstForView = new();
        List<Point> pointsFromContext = _context.Points.ToList();

        pointsFromContext.ForEach(point =>
        {
            poinstForView.Add(new PointsViewModel
            {
                Longitude = point.Longitude,
                Latitude = point.Latitude,
                AlterTypeAsInt = (int)point.Type
            });
        });

        return Json(poinstForView);
    }
}