//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behavior;
using CharSys;
using UnityEngine;

namespace Behavior
{
    public abstract class Task : MonoBehaviour
    {
        public abstract Action ActionDecider(NPC worker, Action currentAction);
        bool canceled = false;
        public bool Alive { get { return !canceled; } }
        
        public JobManager.JobType JobType;

        public void Create(GameObject owner, JobManager.JobType jobType)
        {
            JobType = jobType;
            GameObject.Find("JobManager").GetComponent<JobManager>().AddJob(this, owner);
        }

        public void Cancel(GameObject owner)
        {
            canceled = true;
            GameObject.Find("JobManager").GetComponent<JobManager>().RemoveJob(this, owner);
        }
    }
    public class BuildWall : Task
    {
        private WallBuild _wallToBuild;
        private Action _orderedAction;

        public BuildWall(WallBuild wall)
        {
            _wallToBuild = wall;
        }

        public override Action ActionDecider(NPC worker, Action currentAction)
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
        public override Action ActionDecider(NPC worker, Action currentAction)
        {
            throw new System.NotImplementedException();
        }
    }

}
