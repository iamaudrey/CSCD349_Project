//SmallHealthPotion.cs
//Audrey Henry

using System;

namespace CSCD349Project
{
    public class SmallHealthPotion : GameItem
    {
        //Default constructor for SmallHealthPotion
        public SmallHealthPotion()
        {
            SetName("Small Health Potion");
        }

        public override void Use(GameCharacter character)
        {
            //We can adjust the values to achieve a better balance. AH
            character.GetAttributes()._health += 50.0;

        }
    }

}

