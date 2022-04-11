using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCtrl : MonoBehaviour
{
    static public int money = 15000000;

    public Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateMoney();
    }

    public void Purchase(int cost)
    {
        money -= cost;
        UpdateMoney();
    }

    public void Earn(int cost)
    {
        money += cost;
        UpdateMoney();
    }

    public int GetMoney()
    {
        return money;
    }

    public void UpdateMoney()
    {
        moneyText.text = money.ToString() + "¿ø";
    }
}
