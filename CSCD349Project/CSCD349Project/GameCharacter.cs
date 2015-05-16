using System;
namespace CSCD349Project
{
public abstract class GameCharacter : GameObject, IComparable<GameCharacter>
    {
        private static int noInstances = 0;
        private int _id;
        private CharacterAttributes attributes{set;get;}
        private Party _party{get;set;}  
 
        public GameCharacter(string name) : base(name)
        {
            _id = noInstances ++;
        }
       
        // This constructor is used to create a GamaCharacter instance with a particular id for the purposes 
        // of searching for a character in a list.
        public GameCharacter(int id) : base(""){_id = id;}
    
        public void PerformAbility() { }

        public int CompareTo(GameCharacter other)
        {
 	        return _id - other._id;
        }
<<<<<<< HEAD
        //Capitalized Get in GetAttributes. AH
        public CharacterAttributes GetAttributes()
=======

        public CharacterAttributes getAttributes()
>>>>>>> 6826933b14b3c0ca7ec5a24d4762aacd6cb90ca0
        {
            return this.attributes;
        }

        public override string ToString()
        {
            return GetName() + " " + _id;
        }
    }
}