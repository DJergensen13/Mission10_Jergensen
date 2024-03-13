using Mission10_API.Models;

namespace Mission10_API.Models
{
    public interface IBowlersRepository
    {
        IEnumerable<Bowler> GetBowlersForMarlinsAndSharks();
    }
}
