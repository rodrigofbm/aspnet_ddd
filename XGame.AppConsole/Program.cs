using System;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Services;

namespace XGame.AppConsole {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Iniciando...");

            var service = new PlayerService();
            Console.WriteLine("Criei instancia do serviço");

            AuthPlayerRequest request = new AuthPlayerRequest();
            Console.WriteLine("Criei uma instancia do meu objeto request");

            var response = service.Authenticate(request);

            Console.ReadKey();
        }
    }
}
