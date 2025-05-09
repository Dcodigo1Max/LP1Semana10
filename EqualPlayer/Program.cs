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

      

        public override int GetHashCode()
        {
            return PClass.GetHashCode() ^ Name.GetHashCode();
        }

        public override bool Equals(object other)
        {
            bool equal_value;
            Player otherPlayer = other as Player;
            if(otherPlayer is null) 
                equal_value = false;
            else if(PClass == otherPlayer.PClass && Name == otherPlayer.Name) 
                equal_value = true;
            else
                return false;
            return equal_value;
        }




    }
}
