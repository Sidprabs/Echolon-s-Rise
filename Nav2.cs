using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nav2 : MonoBehaviour {

    public Button Instructions_Button;

    void Start () {

        Button Insbtn = Instructions_Button.GetComponent<Button>();
        Insbtn.onClick.AddListener(Insbtnclick);

    }

    void Insbtnclick()
    {

        SceneManager.LoadScene(3);

    }
}
