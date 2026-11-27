using GYM_project.Entity;
using System.Linq.Expressions;

namespace GYM_project.Reposaterie.InterFaces
{
    public interface IMembershipRepository
    {
        Task<bool> AnyAsync(Expression<Func<MemberShip,bool>> predicate,CancellationToken ct = default);
    }
}
