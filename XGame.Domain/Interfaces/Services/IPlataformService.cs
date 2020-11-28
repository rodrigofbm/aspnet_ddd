using XGame.Domain.Arguments.Plataform;

namespace XGame.Domain.Interfaces.Services {
    public interface IPlataformService {
        CreatePlataformResponse CreatePlataform(CreatePlataformRequest request);
    }
}
