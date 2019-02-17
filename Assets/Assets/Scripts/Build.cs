using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Assets.Scripts
{
    public abstract class Build 
    {
        protected GameObject _gameObject;
        protected Inventory _itemsInBuild = new Inventory();
        protected Inventory _itemsNeeded;

        public Build(Inventory itemsNeeded)
        {
            _itemsNeeded = itemsNeeded;
        }

        public Inventory ItemsLeftToStartConstruction()
        {
            return _itemsNeeded - _itemsInBuild;
        }

    }

    public class WallBuild : Build
    {
        public static readonly int WALL_BUILD_AMOUNT = 20;

        Item.Types wallType;
        

        public WallBuild(Item.Types itemType): base(new Inventory(new[] { new Item (itemType, WALL_BUILD_AMOUNT ) }))
        {
            wallType = itemType;
        }
    }
}
