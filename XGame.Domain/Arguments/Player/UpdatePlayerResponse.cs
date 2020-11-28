using System;

namespace XGame.Domain.Arguments.Player {
    public class UpdatePlayerResponse {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Message { get; set; }

        public static explicit operator UpdatePlayerResponse(Entities.Player entity) {
            return new UpdatePlayerResponse {
                Id = entity.Id,
                Email = entity.Email.Endereco,
                FirstName = entity.Name.FirstName,
                LastName = entity.Name.LastName,
                Message = "Player was updated successfuly!"
            };
        }
    }
}
