using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Start Game
        Time.timeScale = 1;
    }

    // called when clicking UI buttons
    public void ClickUIButtons()
    {
        // pause game
        Time.timeScale = 0;
    }

    // called when clicking exit button
    public void ClickExit()
    {
#if UNITY_EDITOR
        // exit game
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // called when clicking play button
    public void ClickContinue()
    {
        // continue current scene (home)
        Time.timeScale = 1;
    }
}
