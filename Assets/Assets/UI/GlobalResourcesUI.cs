using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalResourcesUI : MonoBehaviour {

    public Text moneyText;
    public Text woodText;
    private GlobalResources globalResources;


    private void UpdateTexts()
    {
        moneyText.text = $"Money: {globalResources.Money}";
        //woodText.text = $"Wood: {globalResources.Wood}";
    }

    // Use this for initialization
    void Start () {
        globalResources = GameObject.Find("GlobalResources").GetComponent<GlobalResources>();
        globalResources.SubcribeAnyResourceUpdate(UpdateTexts);
        UpdateTexts();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
