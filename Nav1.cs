using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nav1 : MonoBehaviour {

    public Button Start_Button;
    public Button Instructions1_Button;
    

    void Start()
    {

        Button startBtn = Start_Button.GetComponent<Button>();
        startBtn.onClick.AddListener(Startbtnclick);

        Button Insbtn = Instructions1_Button.GetComponent<Button>();
        Insbtn.onClick.AddListener(Insbtn1click); 

    }

    void Startbtnclick()
    {

        SceneManager.LoadScene(1);

    }

    void Insbtn1click()
    {

        SceneManager.LoadScene(2);

    }

}
