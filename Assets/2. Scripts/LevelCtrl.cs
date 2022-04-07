using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCtrl : MonoBehaviour
{
    public static int level = 1;

    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateLevel();
    }

    public void Earn(int cost)
    {
        level += cost;
        UpdateLevel();
    }

    public int GetLevel()
    {
        return level;
    }

    public void UpdateLevel()
    {
        levelText.text = "Lv" + level.ToString();
    }
}
