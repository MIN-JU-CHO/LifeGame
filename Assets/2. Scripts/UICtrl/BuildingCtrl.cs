using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCtrl : MonoBehaviour
{
    int type;
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

    public void OpenUI(int i)
    {
        GameObject.Find("DefaultUI").transform.Find("BuildingView").gameObject.SetActive(true);
        type = i;
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
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ¼¼±â
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 0));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ¼¼±â
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 1));
                    // 3Ãþ ¼­Á¡ ÃÊ ¼¼±â
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
                // Á¦ÀÏ ºôµù »ò°í, 1Ãþ 60ºÐ Áö³µÀ» ¶§
                if (building1 && canEarn00)
                {
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ´Ù½Ã ¼¼±â
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 0));
                    canEarn00 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 40ºÐ Áö³µÀ» ¶§
                else if (building1 && canEarn01)
                {
                    costText = Regex.Replace(EarnCost2.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ´Ù½Ã ¼¼±â
                    StartCoroutine(buildContract.TimeRunningOfEarn(0, 1));
                    canEarn01 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 50ºÐ Áö³µÀ» ¶§
                else if (building1 && canEarn02)
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
