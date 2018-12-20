using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour {

    public Transform canvas;
    public Button Start_Button;
    public Button Instructions_Button;

    void Start()
    {

        Button startBtn = Start_Button.GetComponent<Button>();
        startBtn.onClick.AddListener(Startbtnclick);

        Button Insbtn = Instructions_Button.GetComponent<Button>();
        Insbtn.onClick.AddListener(Insbtnclick);

    }

    void Startbtnclick()
    {

        SceneManager.LoadScene(1);

    }

    void Insbtnclick()
    {

        SceneManager.LoadScene(2);

    }

}
