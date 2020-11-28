using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Enums;
using XGame.Domain.Extensions;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities {
    public class Player : Notifiable{
         public Player(Email email, string password) {
            Email = email;
            Password = password;

            new AddNotifications<Player>(this)
                   .IfNullOrInvalidLength(x => x.Password, 6, 32);
        }

        public Player(Name name, Email email, string password) {
            Name = name;
            Email = email;
            Password = password;
            Id = Guid.NewGuid();
            Status = PlayerStatus.InProgress;

            new AddNotifications<Player>(this)
                    .IfNullOrInvalidLength(x => x.Password, 6, 32);
            
            if(IsValid()) Password = Password.ConvertToMD5();

            AddNotifications(Name, Email);
        }

        public void UpdatePlayer(Name name, Email email) {
            new AddNotifications<Player>(this).IfFalse(p => p.Status == PlayerStatus.Active);
        }

        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public PlayerStatus Status { get; private set; }

        public override string ToString() {
            return Name.FirstName + " " + Name.LastName;
        }
    }
}
