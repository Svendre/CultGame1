//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behavior;

namespace Assets.Assets.Scripts
{
    public abstract class Task
    {
        public abstract Action ActionDecider(Action currentAction);
    }

    public class BuildWall : Task
    {
        private WallBuild _wallToBuild;
        private Action _orderedAction;

        public BuildWall(WallBuild wall)
        {
            _wallToBuild = wall;
        }

        public override Action ActionDecider(Action currentAction)
        {
            if(_orderedAction == null)
            {
                _orderedAction = InitialDecider();
                return _orderedAction;
            }
            throw new System.NotImplementedException();
        }

        public Action InitialDecider()
        {
            
            throw new System.NotImplementedException();
        }
    }

    public class HarvestAppletree : Task
    {
        public override Action ActionDecider(Action currentAction)
        {
            throw new System.NotImplementedException();
        }
    }

}
