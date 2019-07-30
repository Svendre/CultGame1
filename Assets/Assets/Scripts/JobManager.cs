using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharSys;
using Behavior;

public class JobManager : MonoBehaviour {
    public enum JobType
    {
        Farming,
        Worshiping,
        Recreational,
        Cleaning
    }

    public class JobBox {
        public JobBox(Task jobInstance, GameObject jobOwner)
        {
            this.jobInstance = jobInstance;
            this.jobOwner = jobOwner;
        }
        public Task jobInstance;
        public GameObject jobOwner;
    }

    public Dictionary<JobType, List<JobBox>> jobsAvailable;
    public List<JobBox> jobsBeingPreformed;

    public void AddJob(Task jobInstance, GameObject jobOwner)
    {
        jobsAvailable[jobInstance.JobType].Add(new JobBox(jobInstance, jobOwner));
    }

    public void RemoveJob(Task jobInstance, GameObject jobOwner)
    {
        jobsAvailable[jobInstance.JobType].RemoveAll(taskBox => taskBox.jobInstance == jobInstance);
        jobsBeingPreformed.RemoveAll(taskBox => taskBox.jobInstance == jobInstance);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
