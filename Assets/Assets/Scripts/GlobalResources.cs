using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalResources : MonoBehaviour {

    private bool updateFlag = false;
    private int _apples = 0;
    public int Apples {
        get { return _apples; }
        private set { updateFlag = true; _apples = value; }
    }
    private int _wood = 100;
    public int Wood
    {
        get { return _wood; }
        private set { updateFlag = true; _wood = value; }
    }
    private int _money = 100;
    public int Money
    {
        get { return _money; }
        private set { updateFlag = true; _money = value; }
    }

    public delegate void AnyResourceUpdate();
    private AnyResourceUpdate anyResourceUpdate;

    public void SubcribeAnyResourceUpdate(AnyResourceUpdate method)
    {
        anyResourceUpdate += method; 
    }

    // Use this for initialization
    void Start () {
		
	}

    //int counter = 0;
	// Update is called once per frame
	void Update () {
        //counter++;
        //if (counter % 20 == 0) Wood = Wood - 1;


        if (updateFlag) anyResourceUpdate();
	}
}
