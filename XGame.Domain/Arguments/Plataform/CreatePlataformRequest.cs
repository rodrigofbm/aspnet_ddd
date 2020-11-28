using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Plataform {
    public class CreatePlataformRequest : IRequest {
        public string Name { get; set; }
    }
}
