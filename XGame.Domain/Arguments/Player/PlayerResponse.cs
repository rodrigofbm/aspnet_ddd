﻿using System;

namespace XGame.Domain.Arguments.Player {
    public class PlayerResponse {
        public Guid Id { get; set; }
        public string CompleteName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public static explicit operator PlayerResponse(Entities.Player entity) {
            return new PlayerResponse {
                Id = entity.Id,
                FirstName = entity.Name.FirstName,
                LastName = entity.Name.LastName,
                Email = entity.Email.Endereco,
                Status = (int)entity.Status,
                CompleteName = entity.ToString()
            };
        }
    }
}
