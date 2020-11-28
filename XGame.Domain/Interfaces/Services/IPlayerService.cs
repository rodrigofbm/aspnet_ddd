using System.Collections.Generic;
using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Services {
    public interface IPlayerService {
        AuthPlayerResponse Authenticate(AuthPlayerRequest request);

        CreatePlayerResponse CreatePlayer(CreatePlayerRequest request);

        UpdatePlayerResponse UpdatePlayer(UpdatePlayerRequest request);

        IEnumerable<PlayerResponse> ListAll();
    }
}
