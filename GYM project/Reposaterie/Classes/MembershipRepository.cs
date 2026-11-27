using GYM_project.context;
using GYM_project.Entity;
using GYM_project.Reposaterie.InterFaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GYM_project.Reposaterie.Classes
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly GymDbContext _dbContext;

        public MembershipRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AnyAsync(Expression<Func<MemberShip, bool>> predicate, CancellationToken ct = default)
        {
            return await _dbContext.Memberships.AnyAsync(predicate,ct);
        }
    }
}
