using Microsoft.EntityFrameworkCore;
using Mission10_API.Models;

namespace Mission10_API.Models
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlingLeagueContext _bowlerContext;
        public EFBowlersRepository(BowlingLeagueContext temp) 
        {
            _bowlerContext = temp;
        }
        //public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;

        public IEnumerable<Bowler> GetBowlersForMarlinsAndSharks()
        {
            return _bowlerContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .ToList();
        }
    }
}
