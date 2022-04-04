using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class ShopCtrl : MonoBehaviour
{
    private Items item;

    private bool isCactusSoldOut;
    public Image cactusImg;
    public Text costCactusText, moneyText, soldOutCactusText;


    private bool isArmchairSoldOut;
    public Image ArmchairImg;
    public Text costArmchairText, soldOutArmchairText;

    public enum Items
    {
        Cactus, Armchair
    }

    public void SetTypeAsCactus()
    {
        item = Items.Cactus;
    }
    public void SetTypeAsSofa()
    {
        item = Items.Armchair;
    }

    public void BuyItem()
    {
        string moneyStr = Regex.Replace(moneyText.text, @"\D", "");
        switch (item)
        {
            case Items.Cactus:
                string costStr = Regex.Replace(costCactusText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (int.Parse(moneyStr) >= int.Parse(costStr) && !isCactusSoldOut)
                {
                    Instantiate(Resources.Load("Flower3"));
                    moneyText.text = (int.Parse(moneyStr) - int.Parse(costStr)).ToString() + "원";
                    isCactusSoldOut = true;
                    soldOutCactusText.text = "SOLD OUT";
                    cactusImg.color = Color.gray;
                }
                break;
            case Items.Armchair:
                string costStr2 = Regex.Replace(costArmchairText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (int.Parse(moneyStr) >= int.Parse(costStr2) && !isArmchairSoldOut)
                {
                    Instantiate(Resources.Load("Armchair"));
                    moneyText.text = (int.Parse(moneyStr) - int.Parse(costStr2)).ToString() + "원";
                    isArmchairSoldOut = true;
                    soldOutArmchairText.text = "SOLD OUT";
                    ArmchairImg.color = Color.gray;
                }
                break;
        }
    }
}
