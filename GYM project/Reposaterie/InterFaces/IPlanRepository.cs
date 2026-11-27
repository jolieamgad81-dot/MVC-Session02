using GYM_project.Entity;

namespace GYM_project.Reposaterie.InterFaces
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GetAllAsync(CancellationToken ct = default);
        Task<Plan?> GetPlanByIdAsync(int id, CancellationToken ct = default);
    }
}
