using GYM_project.context;
using GYM_project.Reposaterie.Classes;
using GYM_project.Reposaterie.InterFaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GYM_project.Controllers
{
    public class PlanController : Controller
    {
        private IPlanRepository _planRepository ;
        private readonly IMembershipRepository _membershipRepository;

        public PlanController(IPlanRepository planRepository,IMembershipRepository membershipRepository)
        {
            _planRepository = planRepository;
            _membershipRepository = membershipRepository;
        }

        public async Task<IActionResult> Index()
        {
            var Plans = await _planRepository.GetAllAsync();   
            return View(Plans);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id,CancellationToken ct)
        {
            var Plan = await _planRepository.GetPlanByIdAsync(id);

            if(Plan is null || !Plan.IsActive)
            {
                return NotFound();
            }
            var hasCurrentMembershipsAsync = await _membershipRepository.AnyAsync(m => m.PlanId == id && m.EndDate > DateTime.Now, ct);
            if (hasCurrentMembershipsAsync)
            {
                return BadRequest();
            }
            return View(Plan);
        }

    }
}
