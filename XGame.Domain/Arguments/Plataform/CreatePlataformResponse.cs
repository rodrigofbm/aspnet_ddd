using System;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Plataform {
    public class CreatePlataformResponse : IResponse {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
