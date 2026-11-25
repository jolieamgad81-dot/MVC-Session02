using GYM_project.context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GYM_project.Controllers
{
    public class PlanController : Controller
    {
        private GymDbContext dbContext = new GymDbContext();
        public async Task<IActionResult> Index()
        {
            var Plans = await dbContext.Plans.ToListAsync();
            return View(Plans);
        }
    }
}
