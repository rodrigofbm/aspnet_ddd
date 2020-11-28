using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.Collections.Generic;
using System.Linq;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services {
    public class PlayerService : Notifiable, IPlayerService {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService() {

        }

        public PlayerService(IPlayerRepository playerRepository) {
            _playerRepository = playerRepository;
        }

        public AuthPlayerResponse Authenticate(AuthPlayerRequest request) {
            if(request == null) {
                AddNotification("AuthPlayerRequest", Message.X0_IS_REQUIRED.ToFormat("AuthPlayerRequest"));
            }

            Email email = new Email(request.Email);
            Player player = new Player(email, request.Password);

            AddNotifications(player, email);

            if (IsInvalid()) return null;

           return (AuthPlayerResponse) _playerRepository.Authenticate(player.Email.Endereco, player.Password);
        }

        public CreatePlayerResponse CreatePlayer(CreatePlayerRequest request) {
            if (request == null) {
                AddNotification("CreatePlayerRequest", Message.X0_IS_REQUIRED.ToFormat("CreatePlayerRequest"));
            }

            var email = new Email(request.Email);
            var name = new Name(request.FirstName, request.LastName);
            var player = new Player(name, email, request.Password);

            AddNotifications(player);

            if (IsInvalid()) return null;

            return (CreatePlayerResponse) _playerRepository.CreatePlayer(player);
        }

        public UpdatePlayerResponse UpdatePlayer(UpdatePlayerRequest request) {
            if (request == null) {
                AddNotification("UpdatePlayerRequest", Message.X0_IS_REQUIRED.ToFormat("UpdatePlayerRequest"));
            }

            Player player = _playerRepository.FindPlayerById(request.Id);

            if (player == null) {
                AddNotification("Id", "data not found");
                return null;
            }

            var name = new Name(request.FirstName, request.LastName);
            var email = new Email(request.Email);
            
            player.UpdatePlayer(name, email);

            AddNotifications(player);

            if (IsInvalid()) return null;

            _playerRepository.UpdatePlayer(player);

            return (UpdatePlayerResponse)player;
        }

        public IEnumerable<PlayerResponse> ListAll() {
            return _playerRepository
                        .ListAllPlayers()
                        .ToList()
                        .Select(player => (PlayerResponse)player)
                        .ToList();
        }
    }
}
