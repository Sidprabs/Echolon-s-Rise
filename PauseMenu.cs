using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public Transform canvas;
    public Button Pause_Button;
    public Button Resume_Button;
    public Button Quit_Button;

    void Start () {
        
        Button PauseBtn = Pause_Button.GetComponent<Button>();
        PauseBtn.onClick.AddListener(Pausebtnclick);

        Button Resumebtn = Resume_Button.GetComponent<Button>();
        Resumebtn.onClick.AddListener(Resumebtnclick);

        Button Quitbtn = Quit_Button.GetComponent<Button>();
        Quitbtn.onClick.AddListener(Quitbtnclick);

    }

    void Pausebtnclick()
    {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;

}

    void Resumebtnclick()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    void Quitbtnclick()
    {
        Application.Quit();
    }

}
