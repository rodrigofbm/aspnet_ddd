﻿using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player {
    public class CreatePlayerRequest : IRequest {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
