using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingCtrl : MonoBehaviour
{
    /*1. �÷��̾� ������ Monster õõ�� �����̰�, ���� �⺻ Idle ����, ü�� ��������, ���� ������ ���� ����
2. �÷��̾� ���� ���
3. ��������Ʈ
4. GameManager ���� 3���� �����س��� �ϳ� ���� ������ ���� ����
5. �ε��� ������Ʈ Ŭ�� ��
6. �ǹ� ���� UI*/

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
        // �� �Ŵ����� sceneLoaded�� ü���� �Ǵ�.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // ü���� �ɾ �� �Լ��� �� ������ ȣ��ȴ�.
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
