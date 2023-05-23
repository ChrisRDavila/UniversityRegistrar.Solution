using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class DepartmentController : Controller
  {
    private readonly UniversityRegistrarContext _db;
    public DepartmentController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Department> model = _db.Departments
                                    .OrderBy(department => department.DepartmentName)
                                    .ToList();
      return View(model);
    }
  }
}