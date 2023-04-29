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

    [HttpPost]
    public IActionResult Add(PointsViewModel model)
    {
        Point forAdd = model;
        _context.Points.Add(forAdd);
        _context.SaveChanges();
        return PartialView("_successPointAddedPartial");
    }

    public IActionResult GetPointsAjaxHandler()
    {
        List<PointsViewModel> poinstForView = new();
        List<Point> pointsFromContext = _context.Points.ToList();

        var response = pointsFromContext.Select(x =>
        {
            return new
            {
                Latitude = x.Latitude,
                Longitude = x.Longitude,
                Type = (int)x.Type
            };
        });

        return Json(response);
    }
}