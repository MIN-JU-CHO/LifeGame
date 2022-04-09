using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCtrl : MonoBehaviour
{
    int type, floor;
    bool building1;
    public bool canEarn00, canEarn01, canEarn02;

    MoneyCtrl moneyCtrl;
    BuildingTransaction buildContract;

    Text CostOfBuilding1, EarnCost1, EarnCost2, EarnCost3;

    // Start is called before the first frame update
    void Start()
    {
        buildContract = GetComponent<BuildingTransaction>();
        CostOfBuilding1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("CostText").gameObject.GetComponent<Text>();
        EarnCost1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor1").transform.Find("CostText").gameObject.GetComponent<Text>();
        EarnCost2 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor2").transform.Find("CostText").gameObject.GetComponent<Text>();
        EarnCost3 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor3").transform.Find("CostText").gameObject.GetComponent<Text>();
        moneyCtrl = GetComponent<MoneyCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When Each buidlings get clicked, they call this func
    // with their own Number(i) Of Building
    public void OpenUI(int i)
    {
        GameObject.Find("DefaultUI").transform.Find("BuildingView").gameObject.SetActive(true);
        type = i;
    }

    // Each functions below can be called when selected each floors' buttons
    public void SelectFloor1()
    {
        floor = 1;
    }
    public void SelectFloor2()
    {
        floor = 2;
    }
    public void SelectFloor3()
    {
        floor = 3;
    }

    public void BuyBuilding()
    {
        switch (type)
        {
            // Á¦ÀÏ ºôµù
            case 0:
                string costText = Regex.Replace(CostOfBuilding1.text, @"\D", "");
                if(moneyCtrl.GetMoney()>= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(0);
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ¼¼±â (start to countdown 1st floor)
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 0));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ¼¼±â (start to countdown 2nd floor)
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 1));
                    // 3Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 2));
                    building1 = true;
                }
                break;
        }
    }

    public void Earn()
    {
        switch (type)
        {
            // Á¦ÀÏ ºôµù
            case 0:
                string costText = Regex.Replace(EarnCost1.text, @"\D", "");
                // Á¦ÀÏ ºôµù »ò°í, 1Ãþ 60ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 1ÃþÀÏ ¶§
                if (building1 && canEarn00 && floor == 1)
                {
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ´Ù½Ã ¼¼±â
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 0));
                    canEarn00 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 40ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building1 && canEarn01 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost2.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ´Ù½Ã ¼¼±â
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 1));
                    canEarn01 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building1 && canEarn02 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost3.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 2));
                    canEarn02 = false;
                }
                break;
        }
    }
}
