using System.Collections.Generic;

namespace Mvc2DemoQuickRefresh.Data
{
    public interface IPlayerRepository
    {
        List<Player> GetAll();
    }

    class PlayerRepository : IPlayerRepository
    {
        public List<Player> GetAll()
        {
            return new List<Player>
            {
                new Player {JerseyNumber = 13, Namn="Mats Sundin", Team = "DIF"},
                new Player {JerseyNumber = 21, Namn="Foppa", Team = "Colorado"}
            };
        }
    }
}