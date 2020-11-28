using System;

namespace XGame.Domain.Entities {
    public class MyGame {
        public Guid Id { get; set; }
        public GamePlataform GamePlataform { get; set; }
        public bool IsWanted { get; set; }
        public bool IsForSale { get; set; }
        public DateTime DateWanted { get; set; }
    }
}
