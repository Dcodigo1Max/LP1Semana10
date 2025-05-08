using System;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass {get;}
        public string Name {get;}
        public Player(PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }

        private static void Main(string[] args)
        {
            
        }

        public enum PlayerClass
        {
            Tank, Fighter, Slayer, Mage,
            Controller, Marksman
        }

        public override int GetHashCode(other)
        {
            return PClass.GetHashCode()^Name.GetHashCode();
        }

        public override bool Equals(object other)
        {
            Player otherPlayer = other as Player;

            if(otherPlayer is null) return false;
            if(PClass == otherPlayer.PClass is Name == otherPlayer.Name) return true;
        }




    }
}
