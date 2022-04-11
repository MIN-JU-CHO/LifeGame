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

    // ºôµù 0
    public bool canEarn00, canEarn01, canEarn02;
    public Text CostOfBuilding0, EarnCost01, EarnCost02, EarnCost03;
    // ºôµù 1
    public bool canEarn10, canEarn11, canEarn12;
    public Text CostOfBuilding1, EarnCost11, EarnCost12, EarnCost13;
    // ºôµù 2
    public bool canEarn20, canEarn21, canEarn22, canEarn23, canEarn24, canEarn25;
    public Text CostOfBuilding2, EarnCost21, EarnCost22, EarnCost23, EarnCost24, EarnCost25, EarnCost26;
    // ºôµù 3
    public bool canEarn30, canEarn31, canEarn32, canEarn33, canEarn34, canEarn35;
    public Text CostOfBuilding3, EarnCost31, EarnCost32, EarnCost33, EarnCost34, EarnCost35, EarnCost36;
    // ºôµù 4
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
            // Á¦ÀÏ ºôµù
            case 0:
                string costText = Regex.Replace(CostOfBuilding0.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(0);
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ¼¼±â (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(0, 0);
                    // 2Ãþ µ¶¼­½Ç ÃÊ ¼¼±â (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(0, 1);
                    // 3Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(0, 2);
                    building1 = true;
                }
                break;

            // ¤·¤· ºôµù
            case 1:
                costText = Regex.Replace(CostOfBuilding1.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(1);
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ¼¼±â (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(1, 0);
                    // 2Ãþ µ¶¼­½Ç ÃÊ ¼¼±â (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(1, 1);
                    // 3Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(1, 2);
                    building2 = true;
                }
                break;
                
            // ¤·¤· ºôµù
            case 2:
                costText = Regex.Replace(CostOfBuilding2.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(2);
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ¼¼±â (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(2, 0);
                    // 2Ãþ µ¶¼­½Ç ÃÊ ¼¼±â (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(2, 1);
                    // 3Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(2, 2);
                    // 4Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(2, 3);
                    // 5Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(2, 4);
                    // 6Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(2, 5);
                    building3 = true;
                }
                break;
                
            // ¤·¤· ºôµù
            case 3:
                costText = Regex.Replace(CostOfBuilding3.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(3);
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ¼¼±â (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(3, 0);
                    // 2Ãþ µ¶¼­½Ç ÃÊ ¼¼±â (start to countdown 2nd floor)
                    buildContract.TimeRunningOfEarn(3, 1);
                    // 3Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(3, 2);
                    // 4Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(3, 3);
                    // 5Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(3, 4);
                    // 6Ãþ ¼­Á¡ ÃÊ ¼¼±â (start to countdown 3rd floor)
                    buildContract.TimeRunningOfEarn(3, 5);
                    building4 = true;
                }
                break;
                
            // ¤·¤· ºôµù
            case 4:
                costText = Regex.Replace(CostOfBuilding4.text, @"\D", "");
                if (moneyCtrl.GetMoney() >= int.Parse(costText))
                {
                    moneyCtrl.Purchase(int.Parse(costText));
                    buildContract.SaveBuying(4);
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ¼¼±â (start to countdown 1st floor)
                    buildContract.TimeRunningOfEarn(4, 0);
                    // 2Ãþ µ¶¼­½Ç ÃÊ ¼¼±â (start to countdown 2nd floor)
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
            // Á¦ÀÏ ºôµù
            case 0:
                string costText = Regex.Replace(EarnCost01.text, @"\D", "");
                // Á¦ÀÏ ºôµù »ò°í, 1Ãþ 60ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 1ÃþÀÏ ¶§
                if (building1 && canEarn00 && floor == 1)
                {
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(0, 0);
                    canEarn00 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 40ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building1 && canEarn01 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost02.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(0, 1);
                    canEarn01 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building1 && canEarn02 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost03.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(0, 2);
                    canEarn02 = false;
                }
                break;
            
            // ¤·¤· ºôµù
            case 1:
                costText = Regex.Replace(EarnCost11.text, @"\D", "");
                // Á¦ÀÏ ºôµù »ò°í, 1Ãþ 60ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 1ÃþÀÏ ¶§
                if (building2 && canEarn10 && floor == 1)
                {
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(1, 0);
                    canEarn10 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 40ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building2 && canEarn11 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost12.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(1, 1);
                    canEarn11 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building2 && canEarn12 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost13.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(1, 2);
                    canEarn12 = false;
                }
                break;
                
            // ¤·¤· ºôµù
            case 2:
                costText = Regex.Replace(EarnCost21.text, @"\D", "");
                // Á¦ÀÏ ºôµù »ò°í, 1Ãþ 60ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 1ÃþÀÏ ¶§
                if (building3 && canEarn20 && floor == 1)
                {
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(2, 0);
                    canEarn20 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 40ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building3 && canEarn21 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost22.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(2, 1);
                    canEarn21 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building3 && canEarn22 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost23.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(2, 2);
                    canEarn22 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 4Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 4ÃþÀÏ ¶§
                else if (building3 && canEarn23 && floor == 4)
                {
                    costText = Regex.Replace(EarnCost24.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(2, 3);
                    canEarn23 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 5Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 5ÃþÀÏ ¶§
                else if (building3 && canEarn24 && floor == 5)
                {
                    costText = Regex.Replace(EarnCost25.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(2, 4);
                    canEarn24 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 6Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 6ÃþÀÏ ¶§
                else if (building3 && canEarn25 && floor == 6)
                {
                    costText = Regex.Replace(EarnCost26.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(2, 5);
                    canEarn25 = false;
                }
                break;
                
            // ¤·¤· ºôµù
            case 3:
                costText = Regex.Replace(EarnCost31.text, @"\D", "");
                // Á¦ÀÏ ºôµù »ò°í, 1Ãþ 60ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 1ÃþÀÏ ¶§
                if (building4 && canEarn30 && floor == 1)
                {
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(3, 0);
                    canEarn30 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 40ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building4 && canEarn31 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost32.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(3, 1);
                    canEarn31 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building4 && canEarn32 && floor == 3)
                {
                    costText = Regex.Replace(EarnCost33.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(3, 2);
                    canEarn32 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 4Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 4ÃþÀÏ ¶§
                else if (building4 && canEarn33 && floor == 4)
                {
                    costText = Regex.Replace(EarnCost34.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(3, 3);
                    canEarn33 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 5Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 5ÃþÀÏ ¶§
                else if (building4 && canEarn34 && floor == 5)
                {
                    costText = Regex.Replace(EarnCost35.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(3, 4);
                    canEarn34 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 6Ãþ 50ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 6ÃþÀÏ ¶§
                else if (building4 && canEarn35 && floor == 6)
                {
                    costText = Regex.Replace(EarnCost36.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 3Ãþ ¼­Á¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(3, 5);
                    canEarn35 = false;
                }
                break;
                
            // ¤·¤· ºôµù
            case 4:
                costText = Regex.Replace(EarnCost41.text, @"\D", "");
                // Á¦ÀÏ ºôµù »ò°í, 1Ãþ 60ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 1ÃþÀÏ ¶§
                if (building5 && canEarn40 && floor == 1)
                {
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 1Ãþ ÆíÀÇÁ¡ ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(4, 0);
                    canEarn40 = false;
                }
                // Á¦ÀÏ ºôµù »ò°í, 2Ãþ 40ºÐ Áö³µ°í, ´©¸¥ ¹öÆ°ÀÌ 2ÃþÀÏ ¶§
                else if (building5 && canEarn41 && floor == 2)
                {
                    costText = Regex.Replace(EarnCost42.text, @"\D", "");
                    // µ· ¹ú±â
                    moneyCtrl.Earn(int.Parse(costText));
                    // 2Ãþ µ¶¼­½Ç ÃÊ ´Ù½Ã ¼¼±â
                    buildContract.TimeRunningOfEarn(4, 1);
                    canEarn41 = false;
                }
                break;

        }
    }
}
