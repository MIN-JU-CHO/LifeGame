using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCtrl : MonoBehaviour
{
    int type, floor;
    bool building1, building2, building3, building4, building5;

    MoneyCtrl moneyCtrl;
    BuildingTransaction buildContract;

    // 網註 0
    public bool canEarn00, canEarn01, canEarn02;
    public Text CostOfBuilding0, EarnCost01, EarnCost02, EarnCost03;
    // 網註 1
    public bool canEarn10, canEarn11, canEarn12;
    public Text CostOfBuilding1, EarnCost11, EarnCost12, EarnCost13;
    // 網註 2
    public bool canEarn20, canEarn21, canEarn22, canEarn23, canEarn24, canEarn25;
    public Text CostOfBuilding2, EarnCost21, EarnCost22, EarnCost23, EarnCost24, EarnCost25, EarnCost26;
    // 網註 3
    public bool canEarn30, canEarn31, canEarn32, canEarn33, canEarn34, canEarn35;
    public Text CostOfBuilding3, EarnCost31, EarnCost32, EarnCost33, EarnCost34, EarnCost35, EarnCost36;
    // 網註 4
    public bool canEarn40, canEarn41;
    public Text CostOfBuilding4, EarnCost41, EarnCost42;

    // Start is called before the first frame update
    void Start()
    {
        buildContract = GetComponent<BuildingTransaction>();
        moneyCtrl = GameObject.Find("GameManager").GetComponent<MoneyCtrl>();
    }

    // called when clicking play button
    public void ClickContinue()
    {
        // continue current scene (home)
        Time.timeScale = 1;
    }

    // When Each buidlings get clicked, they call this func
    // with their own Number(i) Of Building
    public void SetType(int i)
    {
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
    public void SelectFloor4()
    {
        floor = 4;
    }
    public void SelectFloor5()
    {
        floor = 5;
    }
    public void SelectFloor6()
    {
        floor = 6;
    }

    public void BuyBuilding()
    {
        //print("BuyBuilding " + type);
        switch (type)
        {
            // 薯橾 網註
            case 0:
                string costText = Regex.Replace(CostOfBuilding0.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(0);
                    // 1類 ら曖薄 蟾 撮晦 (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(0, 0);
                    // 2類 絮憮褒 蟾 撮晦 (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(0, 1);
                    // 3類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(0, 2);
                    building1 = true;
                }
                break;

            // 仄仄 網註
            case 1:
                costText = Regex.Replace(CostOfBuilding1.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(1);
                    // 1類 ら曖薄 蟾 撮晦 (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(1, 0);
                    // 2類 絮憮褒 蟾 撮晦 (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(1, 1);
                    // 3類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(1, 2);
                    building2 = true;
                }
                break;
                
            // 仄仄 網註
            case 2:
                costText = Regex.Replace(CostOfBuilding2.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(2);
                    // 1類 ら曖薄 蟾 撮晦 (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(2, 0);
                    // 2類 絮憮褒 蟾 撮晦 (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(2, 1);
                    // 3類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(2, 2);
                    // 4類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(2, 3);
                    // 5類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(2, 4);
                    // 6類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(2, 5);
                    building3 = true;
                }
                break;
                
            // 仄仄 網註
            case 3:
                costText = Regex.Replace(CostOfBuilding3.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(3);
                    // 1類 ら曖薄 蟾 撮晦 (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(3, 0);
                    // 2類 絮憮褒 蟾 撮晦 (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(3, 1);
                    // 3類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(3, 2);
                    // 4類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(3, 3);
                    // 5類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(3, 4);
                    // 6類 憮薄 蟾 撮晦 (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(3, 5);
                    building4 = true;
                }
                break;
                
            // 仄仄 網註
            case 4:
                costText = Regex.Replace(CostOfBuilding4.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(4);
                    // 1類 ら曖薄 蟾 撮晦 (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(4, 0);
                    // 2類 絮憮褒 蟾 撮晦 (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(4, 1);
                    building5 = true;
                }
                break;

        }
    }

    public void Earn()
    {
        switch (type)
        {
            // 薯橾 網註
            case 0:
                string costText = Regex.Replace(EarnCost01.text, @"\D", "");
                // 薯橾 網註 麼堅, 1類 60碟 雖陬堅, 援艇 幗が檜 1類橾 陽
                if (building1 && canEarn00 && floor == 1)
                {
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1類 ら曖薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(0, 0);
                    canEarn00 = false;
                }
                // 薯橾 網註 麼堅, 2類 40碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building1 && canEarn01 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost02.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2類 絮憮褒 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(0, 1);
                    canEarn01 = false;
                }
                // 薯橾 網註 麼堅, 2類 50碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building1 && canEarn02 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost03.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(0, 2);
                    canEarn02 = false;
                }
                break;
            
            // 仄仄 網註
            case 1:
                costText = Regex.Replace(EarnCost11.text, @"\D", "");
                // 薯橾 網註 麼堅, 1類 60碟 雖陬堅, 援艇 幗が檜 1類橾 陽
                if (building2 && canEarn10 && floor == 1)
                {
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1類 ら曖薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(1, 0);
                    canEarn10 = false;
                }
                // 薯橾 網註 麼堅, 2類 40碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building2 && canEarn11 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost12.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2類 絮憮褒 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(1, 1);
                    canEarn11 = false;
                }
                // 薯橾 網註 麼堅, 2類 50碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building2 && canEarn12 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost13.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(1, 2);
                    canEarn12 = false;
                }
                break;
                
            // 仄仄 網註
            case 2:
                costText = Regex.Replace(EarnCost21.text, @"\D", "");
                // 薯橾 網註 麼堅, 1類 60碟 雖陬堅, 援艇 幗が檜 1類橾 陽
                if (building3 && canEarn20 && floor == 1)
                {
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1類 ら曖薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(2, 0);
                    canEarn20 = false;
                }
                // 薯橾 網註 麼堅, 2類 40碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building3 && canEarn21 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost22.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2類 絮憮褒 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(2, 1);
                    canEarn21 = false;
                }
                // 薯橾 網註 麼堅, 2類 50碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building3 && canEarn22 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost23.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(2, 2);
                    canEarn22 = false;
                }
                // 薯橾 網註 麼堅, 4類 50碟 雖陬堅, 援艇 幗が檜 4類橾 陽
                else if (building3 && canEarn23 && floor == 4)
                {
                    costText = Regex.Replace(EarnCost24.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(2, 3);
                    canEarn23 = false;
                }
                // 薯橾 網註 麼堅, 5類 50碟 雖陬堅, 援艇 幗が檜 5類橾 陽
                else if (building3 && canEarn24 && floor == 5)
                {
                    costText = Regex.Replace(EarnCost25.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(2, 4);
                    canEarn24 = false;
                }
                // 薯橾 網註 麼堅, 6類 50碟 雖陬堅, 援艇 幗が檜 6類橾 陽
                else if (building3 && canEarn25 && floor == 6)
                {
                    costText = Regex.Replace(EarnCost26.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(2, 5);
                    canEarn25 = false;
                }
                break;
                
            // 仄仄 網註
            case 3:
                costText = Regex.Replace(EarnCost31.text, @"\D", "");
                // 薯橾 網註 麼堅, 1類 60碟 雖陬堅, 援艇 幗が檜 1類橾 陽
                if (building4 && canEarn30 && floor == 1)
                {
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1類 ら曖薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(3, 0);
                    canEarn30 = false;
                }
                // 薯橾 網註 麼堅, 2類 40碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building4 && canEarn31 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost32.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2類 絮憮褒 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(3, 1);
                    canEarn31 = false;
                }
                // 薯橾 網註 麼堅, 2類 50碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building4 && canEarn32 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost33.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(3, 2);
                    canEarn32 = false;
                }
                // 薯橾 網註 麼堅, 4類 50碟 雖陬堅, 援艇 幗が檜 4類橾 陽
                else if (building4 && canEarn33 && floor == 4)
                {
                    costText = Regex.Replace(EarnCost34.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(3, 3);
                    canEarn33 = false;
                }
                // 薯橾 網註 麼堅, 5類 50碟 雖陬堅, 援艇 幗が檜 5類橾 陽
                else if (building4 && canEarn34 && floor == 5)
                {
                    costText = Regex.Replace(EarnCost35.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(3, 4);
                    canEarn34 = false;
                }
                // 薯橾 網註 麼堅, 6類 50碟 雖陬堅, 援艇 幗が檜 6類橾 陽
                else if (building4 && canEarn35 && floor == 6)
                {
                    costText = Regex.Replace(EarnCost36.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3類 憮薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(3, 5);
                    canEarn35 = false;
                }
                break;
                
            // 仄仄 網註
            case 4:
                costText = Regex.Replace(EarnCost41.text, @"\D", "");
                // 薯橾 網註 麼堅, 1類 60碟 雖陬堅, 援艇 幗が檜 1類橾 陽
                if (building5 && canEarn40 && floor == 1)
                {
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1類 ら曖薄 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(4, 0);
                    canEarn40 = false;
                }
                // 薯橾 網註 麼堅, 2類 40碟 雖陬堅, 援艇 幗が檜 2類橾 陽
                else if (building5 && canEarn41 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost42.text, @"\D", "");
                    // 絲 弊晦
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2類 絮憮褒 蟾 棻衛 撮晦
                    buildContract.TimeRunningOfEarn(4, 1);
                    canEarn41 = false;
                }
                break;

        }
    }
}
