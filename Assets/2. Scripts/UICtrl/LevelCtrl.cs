using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class LevelCtrl : MonoBehaviour
{
    private Abilities ably;
    private int level = 1;
    public Text levelTextOfList, costText, levelText, moneyText;

    public enum Abilities{
        Attack
    }
    
    public void SetTypeAsAttack()
    {
        ably = Abilities.Attack;
    }

    public void UpgradeAbilities()
    {
        string moneyStr = Regex.Replace(moneyText.text, @"\D", "");
        switch (ably)
        {
            case Abilities.Attack:
                string costStr = Regex.Replace(costText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때
                if (int.Parse(moneyStr) >= int.Parse(costStr))
                {
                    level++;
                    levelText.text = "Lv" + level.ToString();
                    levelTextOfList.text = "Lv." + level.ToString()
                        + " -> " + "Lv." + (level + 1).ToString();
                    costText.text = (int.Parse(costStr) + 2000).ToString() + "원";
                    moneyText.text = (int.Parse(moneyStr) - int.Parse(costStr)).ToString() + "원";
                }
                break;
        }
    }
}
