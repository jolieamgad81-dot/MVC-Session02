using GYM_project.context;
using GYM_project.Entity;
using GYM_project.Reposaterie.InterFaces;
using Microsoft.EntityFrameworkCore;

namespace GYM_project.Reposaterie.Classes
{
    public class PlanRepository : IPlanRepository
    {
        private GymDbContext _dbContext ;
        public PlanRepository( GymDbContext dbContext )
        {
            _dbContext = dbContext ;
        }
        public async Task<IEnumerable<Plan>> GetAllAsync(CancellationToken ct = default)
        {
            return await _dbContext.Plans.AsNoTracking().ToListAsync(ct);
        }

        public async Task<Plan?> GetPlanByIdAsync(int id, CancellationToken ct = default)
        {
            return await _dbContext.Plans.FindAsync([id], cancellationToken: ct);
        }
    }
}
