using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nav3 : MonoBehaviour {

    public Button End_Button;

    void Start()
    {

        Button endbtn = End_Button.GetComponent<Button>();
        endbtn.onClick.AddListener(Endbtnclick);

    }

    void Endbtnclick()
    {

        SceneManager.LoadScene(0);

    }
}
