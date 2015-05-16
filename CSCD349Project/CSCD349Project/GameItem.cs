//GameItem.cs
//Audrey Henry


using System;
using System.Collections.Generic;

namespace CSCD349Project
{
    abstract class GameItem : GameObject
    {
        public GameItem()
        { }


        //Use method applies item to given character
        abstract void Use(GameCharacter character);
    }
}