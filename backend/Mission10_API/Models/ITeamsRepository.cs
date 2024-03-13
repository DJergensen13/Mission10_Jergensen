using Mission10_API.Models;

namespace Mission10_API.Models
{
    public interface ITeamsRepository
    {
        IEnumerable<Team> Teams { get; }
    }
}
