using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingCtrl : MonoBehaviour
{
    // Always called even if it is not active
    private void Awake()
    {
        // Search and save every objects that has SettingCtrl script
        SettingCtrl[] script = FindObjectsOfType<SettingCtrl>();

        // If this scene has GameManager objects more than 1
        if (script.Length > 1)
        {
            // Destroy older one
            Destroy(script[1].gameObject);
        }

        // Don't destroy this object(GameManager) even if scene changes
        DontDestroyOnLoad(gameObject);
        //GetComponent<LevelCtrl>().UpdateLevel();
        //GetComponent<MoneyCtrl>().UpdateMoney();
    }

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
