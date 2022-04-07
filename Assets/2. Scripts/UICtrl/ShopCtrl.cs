using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class ShopCtrl : MonoBehaviour
{
    public bool isShop = true;
    private Items item;

    MoneyCtrl moneyCtrl;

    private bool isCactusSoldOut;
    Image cactusImg;
    Text costCactusText, soldOutCactusText;


    private bool isArmchairSoldOut;
    Image ArmchairImg;
    Text costArmchairText, soldOutArmchairText;

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
        if (!isShop)
        {
            return;
        }
        switch (item)
        {
            case Items.Cactus:
                string costStr = Regex.Replace(costCactusText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isCactusSoldOut)
                {
                    Instantiate(Resources.Load("Flower3"));
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isCactusSoldOut = true;
                    soldOutCactusText.text = "SOLD OUT";
                    cactusImg.color = Color.gray;
                }
                break;
            case Items.Armchair:
                string costStr2 = Regex.Replace(costArmchairText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr2) && !isArmchairSoldOut)
                {
                    Instantiate(Resources.Load("Armchair"));
                    moneyCtrl.Purchase(int.Parse(costStr2));
                    isArmchairSoldOut = true;
                    soldOutArmchairText.text = "SOLD OUT";
                    ArmchairImg.color = Color.gray;
                }
                break;
        }
    }

    private void Start()
    {
        cactusImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").GetComponent<Image>();
        costCactusText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").transform.Find("ItemText").GetComponent<Text>();
        soldOutCactusText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").transform.Find("SoldOut").GetComponent<Text>();
        ArmchairImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").GetComponent<Image>();
        costArmchairText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").transform.Find("ItemText").GetComponent<Text>();
        soldOutArmchairText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").transform.Find("SoldOut").GetComponent<Text>();
        moneyCtrl = GetComponent<MoneyCtrl>();
    }
}
