using System;
using System.Collections.Generic;
namespace CSCD349Project
{
    public class GameObject
    {
        private Cell _occupyingCell;
        private Sprite _sprite;
        //private GameObjectType _type{get;set;}
        private string _name;

        public string GetName() { return _name; }
        //Added a SetName method so subclasses can set their own names. AH
        protected void SetName(string name) { _name = name; }

        public Cell GetCell() { return _occupyingCell; }
        public void SetCell(Cell value) { if (value != null) _occupyingCell = value; }

        public Sprite GetSprite() { return _sprite; }
        public void SetSprite(Sprite value) { if(value != null ) _sprite = value;}

        //Added this constructor with no arguments, so it'll be easier to initialize simple objects
        //like health potions. AH
        public GameObject()
        {
            _name = "";
        }

        public GameObject(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }



    public enum GameObjectType{gameCharacter, gameItem, }

    public class Sprite
    {
        public Sprite(string path)
        {

        }
        
    }
}
