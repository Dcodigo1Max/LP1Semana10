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




    }
}
