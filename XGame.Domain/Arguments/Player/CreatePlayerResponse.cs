using System;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player {
    public class CreatePlayerResponse : IResponse {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator CreatePlayerResponse(Entities.Player entity) {
            return new CreatePlayerResponse { Id = entity.Id, Message = "Player was created successfuly!" };
        }
    }
}
