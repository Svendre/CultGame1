using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Behavior;
using CharSys;

public class AppleWorldItem : MonoBehaviour {

    public class PickupAppleJob : Task
    {
        public override Action ActionDecider(NPC worker, Action currentAction)
        {
            throw new System.NotImplementedException();
        }
    }
    PickupAppleJob appleJob;
    JobManager jobManager;

	// Use this for initialization
	void Start () {
        appleJob = new PickupAppleJob();
        appleJob.Create(gameObject, JobManager.JobType.Cleaning);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        appleJob.Cancel(gameObject);
    }
}
