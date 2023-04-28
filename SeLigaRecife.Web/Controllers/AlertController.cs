using Microsoft.AspNetCore.Mvc;
using SeLigaRecife.Web.Context;

namespace SeLigaRecife.Web.Controllers;

public class AlertController : Controller
{
    public SeLigaRecifeDbContext _context;

    public AlertController(SeLigaRecifeDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var alerts = _context.Alerts.ToList();
        return Json(alerts);
    }
}