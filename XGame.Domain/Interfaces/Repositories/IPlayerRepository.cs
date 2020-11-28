using System;
using System.Collections.Generic;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories {
    public interface IPlayerRepository {
        Player Authenticate(string email, string password);

        Player CreatePlayer(Player player);

        IEnumerable<Player> ListAllPlayers();

        Player FindPlayerById(Guid id);

        void UpdatePlayer(Player player);
    }
}
