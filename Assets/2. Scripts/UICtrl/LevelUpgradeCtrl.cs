using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpgradeCtrl : MonoBehaviour
{
    private Abilities ably;
    public Text levelTextOfList, costText;

    LevelCtrl levelCtrl;
    MoneyCtrl moneyCtrl;

    public enum Abilities{
        Attack
    }
    
    public void SetTypeAsAttack()
    {
        ably = Abilities.Attack;
    }

    public void UpgradeAbilities()
    {
        switch (ably)
        {
            case Abilities.Attack:
                string costStr = Regex.Replace(costText.text, @"\D", "");

                // ���� ������ ���� ���� �̻��� ��
                if (moneyCtrl.GetMoney() >= int.Parse(costStr))
                {
                    levelCtrl.Earn(1);
                    levelTextOfList.text = "Lv." + levelCtrl.GetLevel().ToString()
                        + " -> " + "Lv." + (levelCtrl.GetLevel() + 1).ToString();
                    costText.text = (int.Parse(costStr) + 2000).ToString() + "��";
                    moneyCtrl.Purchase(int.Parse(costStr));
                }
                break;
        }
    }

    private void Start()
    {
        moneyCtrl = GetComponent<MoneyCtrl>();
        levelCtrl = GetComponent<LevelCtrl>();
    }
}
