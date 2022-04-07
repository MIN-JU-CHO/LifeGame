using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCtrl : MonoBehaviour
{
    int type;
    bool building1;

    MoneyCtrl moneyCtrl;

    Text CostOfBuilding1, EarnCost1;

    // Start is called before the first frame update
    void Start()
    {
        CostOfBuilding1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building").transform.Find("CostText").gameObject.GetComponent<Text>();
        //ContentOfBuilding1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building").transform.Find("ContentText").gameObject.GetComponent<Text>();
        EarnCost1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Floor1").transform.Find("CostText").gameObject.GetComponent<Text>();
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
            case 0:
                string costText = Regex.Replace(CostOfBuilding1.text, @"\D", "");
                if(moneyCtrl.GetMoney()>= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    CostOfBuilding1.text = "업그레이드" + "\n" + "500000 원";
                    building1 = true;
                }
                break;
        }
    }

    public void Earn()
    {
        switch (type)
        {
            case 0:
                string costText = Regex.Replace(EarnCost1.text, @"\D", "");
                if (building1)
                {
                    moneyCtrl.Earn(int.Parse(costText));
                }
                break;
        }
    }
}
