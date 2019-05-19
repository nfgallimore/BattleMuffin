using System.Threading.Tasks;
using BattleMuffin.Models.Warcraft.GameData;
using BattleMuffin.Web;

namespace BattleMuffin.Clients
{
    public interface IWarcraftGameDataClient
    {
        Task<RequestResult<AchievementCategoryIndex>> GetAchievementCategoryIndex();
    }
}
