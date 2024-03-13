using Mission10_API.Models;

namespace Mission10_API.Models
{
    public class EFTeamsRepository : ITeamsRepository
    {
        private BowlingLeagueContext _teamContext;
        public EFTeamsRepository(BowlingLeagueContext temp)
        {
            _teamContext = temp;
        }
        public IEnumerable<Team> Teams => _teamContext.Teams;
    }
}
