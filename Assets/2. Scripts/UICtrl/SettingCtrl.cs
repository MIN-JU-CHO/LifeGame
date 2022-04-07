using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingCtrl : MonoBehaviour
{
    /*1. 플레이어 만나면 Monster 천천히 움직이게, 몬스터 기본 Idle 상태, 체력 게이지바, 맞을 때마다 돈도 벌기
2. 플레이어 마법 쏘기
3. 스폰포인트
4. GameManager 몬스터 3마리 생성해놓고 하나 죽을 때마다 새로 생성
5. 부동산 오브젝트 클릭 시
6. 건물 매입 UI*/

    // Always called even if it is not active
    private void Awake()
    {
        // Search and save every objects that has SettingCtrl script
        SettingCtrl[] script = FindObjectsOfType<SettingCtrl>();
        // Search and save every objects whose tag is UI
        GameObject[] gmo = GameObject.FindGameObjectsWithTag("UI");

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
        DontDestroyOnLoad(GameObject.Find("DefaultUI").gameObject);
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


    void OnEnable()
    {
        // 씬 매니저의 sceneLoaded에 체인을 건다.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // 체인을 걸어서 이 함수는 매 씬마다 호출된다.
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Get script which is ShopCtrl
        ShopCtrl script = GetComponent<ShopCtrl>();
        if(scene.name == "Home")
        {
            // Able to buy shop item, if it is in Home Scene
            script.isShop = true;
        }
        else
        {
            // Disable to buy shop item, if it is not in Home Scene
            script.isShop = false;
        }
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}
