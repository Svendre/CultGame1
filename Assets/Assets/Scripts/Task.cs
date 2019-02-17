﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Assets.Scripts
{
    public abstract class Task
    {
        public abstract Action ActionDesider(Action currentAction);
    }

    public class BuildWall : Task
    {
        private WallBuild _wallToBuild;
        private Action _orderedAction;

        public BuildWall(WallBuild wall)
        {
            _wallToBuild = wall;
        }

        public override Action ActionDesider(Action currentAction)
        {
            if(_orderedAction == null)
            {
                _orderedAction = InitialDecider();
                return _orderedAction;
            }
            throw new NotImplementedException();
        }

        public Action InitialDecider()
        {
            
            throw new NotImplementedException();
        }
    }

}