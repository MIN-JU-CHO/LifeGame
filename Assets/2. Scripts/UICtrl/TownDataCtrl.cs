using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TownDataCtrl : MonoBehaviour
{
    // Always called even if it is not active
    private void Awake()
    {
        // Search and save every objects that has TownDataCtrl script
        TownDataCtrl[] script = FindObjectsOfType<TownDataCtrl>();
        // Search and save every objects whose tag is UI
        GameObject[] gmo = GameObject.FindGameObjectsWithTag("BUI");

        // If this scene has GameManager objects more than 1
        if (script.Length > 1)
        {
            // Destroy older one
            Destroy(script[1].gameObject);
        }

        // If this scene has DefaultUI objects more than 1
        if (gmo.Length > 1)
        {
            // Destroy older one
            Destroy(gmo[1].gameObject);
        }

        // Don't destroy this object(GameManager) even if scene changes
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(GameObject.Find("BuildingManage").gameObject);
        //GetComponent<LevelCtrl>().UpdateLevel();
        //GetComponent<MoneyCtrl>().UpdateMoney();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Start Game
        Time.timeScale = 1;
    }
}
