using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenuScript : MonoBehaviour {

    public Button btn_newGame, btn_exit;

    void Start()
    {
        Button btn = btn_newGame.GetComponent<Button>();
        Button btn2 = btn_exit.GetComponent<Button>();
        //Calls the TaskOnClick method when you click the Button
        btn.onClick.AddListener(TaskOnClick);

        btn_exit.onClick.AddListener(delegate { ExitGame(); });
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Application.LoadLevel(1);
    }

    void ExitGame()
    {
        //Output this to console when the Button is clicked
        Application.Quit();
    }
}
