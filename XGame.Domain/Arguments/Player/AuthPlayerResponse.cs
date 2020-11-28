using System;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player {
    public class AuthPlayerResponse : IResponse {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public static explicit operator AuthPlayerResponse(Entities.Player enitity) {
            return new AuthPlayerResponse {
                FirstName = enitity.Name.FirstName,
                Email = enitity.Email.Endereco,
                Status = (int)enitity.Status
            };
        }
    }
}
