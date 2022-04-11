using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BuildingTransaction : MonoBehaviour
{
    // 임대료 받을 때만 씀
    BuildingCtrl buildCtrl;



    // 제일 빌딩 데이터
    int BuildingUpgrade0 = 500000, first0 = 1, second0 = 2;
    // 제일 빌딩의 층만
    public Text CostOfBuilding0, LevelOfBuilding0;
    public Text TimeOfFloor01, TimeOfFloor02, TimeOfFloor03;
    public Text CostOfFloor01, CostOfFloor02, CostOfFloor03;
    // 제일 빌딩 각 층의 데이터
    bool startTimer00, startTimer01, startTimer02;
    float timer00, timer01, timer02;
    int cost00 = 5000, cost01 = 3000, cost02 = 2000;
    
    // ㅇㅇ 빌딩 데이터
    int BuildingUpgrade1 = 800000, first1 = 1, second1 = 2;
    // ㅇㅇ 빌딩의 층만
    public Text CostOfBuilding1, LevelOfBuilding1;
    public Text TimeOfFloor11, TimeOfFloor12, TimeOfFloor13;
    public Text CostOfFloor11, CostOfFloor12, CostOfFloor13;
    // ㅇㅇ 빌딩 각 층의 데이터
    bool startTimer10, startTimer11, startTimer12;
    float timer10, timer11, timer12;
    int cost10 = 7000, cost11 = 8000, cost12 = 6000;
    
    // ㅇㅇ 빌딩 데이터
    int BuildingUpgrade2 = 800000, first2 = 1, second2 = 2;
    // ㅇㅇ 빌딩의 층만
    public Text CostOfBuilding2, LevelOfBuilding2;
    public Text TimeOfFloor21, TimeOfFloor22, TimeOfFloor23, TimeOfFloor24, TimeOfFloor25, TimeOfFloor26;
    public Text CostOfFloor21, CostOfFloor22, CostOfFloor23, CostOfFloor24, CostOfFloor25, CostOfFloor26;
    // ㅇㅇ 빌딩 각 층의 데이터
    bool startTimer20, startTimer21, startTimer22, startTimer23, startTimer24, startTimer25;
    float timer20, timer21, timer22, timer23, timer24, timer25;
    int cost20 = 6000, cost21 = 9000, cost22 = 10000, cost23 = 10000, cost24 = 10000, cost25 = 10000;
    
    // ㅇㅇ 빌딩 데이터
    int BuildingUpgrade3 = 1000000, first3 = 1, second3 = 2;
    // ㅇㅇ 빌딩의 층만
    public Text CostOfBuilding3, LevelOfBuilding3;
    public Text TimeOfFloor31, TimeOfFloor32, TimeOfFloor33, TimeOfFloor34, TimeOfFloor35, TimeOfFloor36;
    public Text CostOfFloor31, CostOfFloor32, CostOfFloor33, CostOfFloor34, CostOfFloor35, CostOfFloor36;
    // ㅇㅇ 빌딩 각 층의 데이터
    bool startTimer30, startTimer31, startTimer32, startTimer33, startTimer34, startTimer35;
    float timer30, timer31, timer32, timer33, timer34, timer35;
    int cost30 = 20000, cost31 = 30000, cost32 = 15000, cost33 = 15000, cost34 = 15000, cost35 = 15000;
    
    // ㅇㅇ 빌딩 데이터
    int BuildingUpgrade4 = 300000, first4 = 1, second4 = 2;
    // ㅇㅇ 빌딩의 층만
    public Text CostOfBuilding4, LevelOfBuilding4;
    public Text TimeOfFloor41, TimeOfFloor42;
    public Text CostOfFloor41, CostOfFloor42;
    // ㅇㅇ 빌딩 각 층의 데이터
    bool startTimer40, startTimer41;
    float timer40, timer41;
    int cost40 = 5000, cost41 = 3000;

    public void SaveBuying(int i)
    {
        switch (i)
        {
            // 제일 빌딩
            case 0:
                {
                    CostOfBuilding0.text = "업그레이드" + "\n" + BuildingUpgrade0.ToString() + " 원";
                    BuildingUpgrade0 += 200000;
                    LevelOfBuilding0.text = first0.ToString() + "등급 -> " + second0.ToString() + "등급";
                    first0++; second0++;
                    // 각 층 임대료 상승
                    CostOfFloor01.text = "한 시간 당" + "\n" + cost00.ToString() + "원";
                    CostOfFloor02.text = "한 시간 당" + "\n" + cost01.ToString() + "원";
                    CostOfFloor03.text = "한 시간 당" + "\n" + cost02.ToString() + "원";
                    cost00 += 1000;
                    cost01 += 1000;
                    cost02 += 1000;
                }
                break;

            // ㅇㅇ 빌딩
            case 1:
                {
                    CostOfBuilding1.text = "업그레이드" + "\n" + BuildingUpgrade1.ToString() + " 원";
                    BuildingUpgrade1 += 200000;
                    LevelOfBuilding1.text = first1.ToString() + "등급 -> " + second1.ToString() + "등급";
                    first1++; second1++;
                    // 각 층 임대료 상승
                    CostOfFloor11.text = "한 시간 당" + "\n" + cost10.ToString() + "원";
                    CostOfFloor12.text = "한 시간 당" + "\n" + cost11.ToString() + "원";
                    CostOfFloor13.text = "한 시간 당" + "\n" + cost12.ToString() + "원";
                    cost10 += 2000;
                    cost11 += 2000;
                    cost12 += 2000;
                }
                break;
                
            // ㅇㅇ 빌딩
            case 2:
                {
                    CostOfBuilding2.text = "업그레이드" + "\n" + BuildingUpgrade2.ToString() + " 원";
                    BuildingUpgrade2 += 200000;
                    LevelOfBuilding2.text = first2.ToString() + "등급 -> " + second2.ToString() + "등급";
                    first2++; second2++;
                    // 각 층 임대료 상승
                    CostOfFloor21.text = "한 시간 당" + "\n" + cost20.ToString() + "원";
                    CostOfFloor22.text = "한 시간 당" + "\n" + cost21.ToString() + "원";
                    CostOfFloor23.text = "한 시간 당" + "\n" + cost22.ToString() + "원";
                    CostOfFloor24.text = "한 시간 당" + "\n" + cost23.ToString() + "원";
                    CostOfFloor25.text = "한 시간 당" + "\n" + cost24.ToString() + "원";
                    CostOfFloor26.text = "한 시간 당" + "\n" + cost25.ToString() + "원";
                    cost20 += 2000;
                    cost21 += 2000;
                    cost22 += 2000;
                    cost23 += 2000;
                    cost24 += 2000;
                    cost25 += 2000;
                }
                break;
                
            // ㅇㅇ 빌딩
            case 3:
                {
                    CostOfBuilding3.text = "업그레이드" + "\n" + BuildingUpgrade3.ToString() + " 원";
                    BuildingUpgrade3 += 200000;
                    LevelOfBuilding3.text = first3.ToString() + "등급 -> " + second3.ToString() + "등급";
                    first3++; second3++;
                    // 각 층 임대료 상승
                    CostOfFloor31.text = "한 시간 당" + "\n" + cost30.ToString() + "원";
                    CostOfFloor32.text = "한 시간 당" + "\n" + cost31.ToString() + "원";
                    CostOfFloor33.text = "한 시간 당" + "\n" + cost32.ToString() + "원";
                    CostOfFloor34.text = "한 시간 당" + "\n" + cost33.ToString() + "원";
                    CostOfFloor35.text = "한 시간 당" + "\n" + cost34.ToString() + "원";
                    CostOfFloor36.text = "한 시간 당" + "\n" + cost35.ToString() + "원";
                    cost30 += 3000;
                    cost31 += 3000;
                    cost32 += 3000;
                    cost33 += 3000;
                    cost34 += 3000;
                    cost35 += 3000;
                }
                break;

            // ㅇㅇ 빌딩
            case 4:
                {
                    CostOfBuilding4.text = "업그레이드" + "\n" + BuildingUpgrade4.ToString() + " 원";
                    BuildingUpgrade4 += 200000;
                    LevelOfBuilding4.text = first4.ToString() + "등급 -> " + second4.ToString() + "등급";
                    first4++; second4++;
                    // 각 층 임대료 상승
                    CostOfFloor41.text = "한 시간 당" + "\n" + cost40.ToString() + "원";
                    CostOfFloor42.text = "한 시간 당" + "\n" + cost41.ToString() + "원";
                    cost40 += 500;
                    cost41 += 500;
                }
                break;

        }
    }

    public void TimeRunningOfEarn(int building, int floor)
    {
        switch (building)
        {
            // 제일 빌딩
            case 0:
                switch (floor)
                {
                    // 1층 편의점
                    case 0:
                        timer00 = 60;
                        startTimer00 = true;
                        break;
                    // 2층 독서실
                    case 1:
                        timer01 = 40;
                        startTimer01 = true;
                        break;
                    // 3층 서점
                    case 2:
                        timer02 = 50;
                        startTimer02 = true;
                        break;
                }
                break;

            // ㅇㅇ 빌딩
            case 1:
                switch (floor)
                {
                    // 1층 편의점
                    case 0:
                        timer10 = 80;
                        startTimer10 = true;
                        break;
                    // 2층 독서실
                    case 1:
                        timer11 = 90;
                        startTimer11 = true;
                        break;
                    // 3층 서점
                    case 2:
                        timer12 = 70;
                        startTimer12 = true;
                        break;
                }
                break;
                
            // ㅇㅇ 빌딩
            case 2:
                switch (floor)
                {
                    // 1층 편의점
                    case 0:
                        timer20 = 60;
                        startTimer20 = true;
                        break;
                    // 2층 독서실
                    case 1:
                        timer21 = 80;
                        startTimer21 = true;
                        break;
                    // 3층 서점
                    case 2:
                        timer22 = 110;
                        startTimer22 = true;
                        break;
                    // 4층 서점
                    case 3:
                        timer23 = 110;
                        startTimer23 = true;
                        break;
                    // 5층 서점
                    case 4:
                        timer24 = 110;
                        startTimer24 = true;
                        break;
                    // 6층 서점
                    case 5:
                        timer25 = 110;
                        startTimer25 = true;
                        break;
                }
                break;
                
            // ㅇㅇ 빌딩
            case 3:
                switch (floor)
                {
                    // 1층 편의점
                    case 0:
                        timer30 = 120;
                        startTimer30 = true;
                        break;
                    // 2층 독서실
                    case 1:
                        timer31 = 130;
                        startTimer31 = true;
                        break;
                    // 3층 서점
                    case 2:
                        timer32 = 70;
                        startTimer32 = true;
                        break;
                    // 3층 서점
                    case 3:
                        timer33 = 70;
                        startTimer33 = true;
                        break;
                    // 3층 서점
                    case 4:
                        timer34 = 70;
                        startTimer34 = true;
                        break;
                    // 3층 서점
                    case 5:
                        timer35 = 70;
                        startTimer35 = true;
                        break;
                }
                break;
                
            // ㅇㅇ 빌딩
            case 4:
                switch (floor)
                {
                    // 1층 편의점
                    case 0:
                        timer40 = 60;
                        startTimer40 = true;
                        break;
                    // 2층 독서실
                    case 1:
                        timer41 = 40;
                        startTimer41 = true;
                        break;
                }
                break;

        }
    }

    // Start is called before the first0 frame update
    void Start()
    {
        buildCtrl = GetComponent<BuildingCtrl>();
        // 0번 빌딩
        {
            CostOfBuilding0 = buildCtrl.CostOfBuilding0;
            CostOfFloor01 = buildCtrl.EarnCost01;
            CostOfFloor02 = buildCtrl.EarnCost02;
            CostOfFloor03 = buildCtrl.EarnCost03;
        }
        // 1번 빌딩
        {
            CostOfBuilding1 = buildCtrl.CostOfBuilding1;
            CostOfFloor11 = buildCtrl.EarnCost11;
            CostOfFloor12 = buildCtrl.EarnCost12;
            CostOfFloor13 = buildCtrl.EarnCost13;
        }
        // 2번 빌딩
        {
            CostOfBuilding2 = buildCtrl.CostOfBuilding2;
            CostOfFloor21 = buildCtrl.EarnCost21;
            CostOfFloor22 = buildCtrl.EarnCost22;
            CostOfFloor23 = buildCtrl.EarnCost23;
            CostOfFloor24 = buildCtrl.EarnCost24;
            CostOfFloor25 = buildCtrl.EarnCost25;
            CostOfFloor26 = buildCtrl.EarnCost26;
        }
        // 3번 빌딩
        {
            CostOfBuilding3 = buildCtrl.CostOfBuilding3;
            CostOfFloor31 = buildCtrl.EarnCost31;
            CostOfFloor32 = buildCtrl.EarnCost32;
            CostOfFloor33 = buildCtrl.EarnCost33;
            CostOfFloor34 = buildCtrl.EarnCost34;
            CostOfFloor35 = buildCtrl.EarnCost35;
            CostOfFloor36 = buildCtrl.EarnCost36;
        }
        // 4번 빌딩
        {
            CostOfBuilding4 = buildCtrl.CostOfBuilding4;
            CostOfFloor41 = buildCtrl.EarnCost41;
            CostOfFloor42 = buildCtrl.EarnCost42;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Timer0
        {
            if (startTimer00)
            {
                if (timer00 >= 0)
                {
                    timer00 = timer00 - Time.deltaTime;
                    TimeOfFloor01.text = ((int)timer00).ToString() + "분 남음";
                }
                if ((int)timer00 <= 0)
                {
                    TimeOfFloor01.text = "임대료 받기";
                    buildCtrl.canEarn00 = true;
                    startTimer00 = false;
                    return;
                }
            }

            if (startTimer01)
            {
                if (timer01 >= 0)
                {
                    timer01 -= Time.deltaTime;
                    TimeOfFloor02.text = ((int)timer01).ToString() + "분 남음";
                }
                if ((int)timer01 <= 0)
                {
                    TimeOfFloor02.text = "임대료 받기";
                    buildCtrl.canEarn01 = true;
                    startTimer01 = false;
                    return;
                }
            }

            if (startTimer02)
            {
                if (timer02 >= 0)
                {
                    timer02 -= Time.deltaTime;
                    TimeOfFloor03.text = ((int)timer02).ToString() + "분 남음";
                }
                if ((int)timer02 <= 0)
                {
                    TimeOfFloor03.text = "임대료 받기";
                    buildCtrl.canEarn02 = true;
                    startTimer02 = false;
                    return;
                }
            }

        }

        // Timer1
        {
            if (startTimer10)
            {
                if (timer10 >= 0)
                {
                    timer10 -= Time.deltaTime;
                    TimeOfFloor11.text = ((int)timer10).ToString() + "분 남음";
                }
                if ((int)timer10 <= 0)
                {
                    TimeOfFloor11.text = "임대료 받기";
                    buildCtrl.canEarn10 = true;
                    startTimer10 = false;
                    return;
                }
            }

            if (startTimer11)
            {
                if (timer11 >= 0)
                {
                    timer11 -= Time.deltaTime;
                    TimeOfFloor12.text = ((int)timer11).ToString() + "분 남음";
                }
                if ((int)timer11 <= 0)
                {
                    TimeOfFloor12.text = "임대료 받기";
                    buildCtrl.canEarn11 = true;
                    startTimer11 = false;
                    return;
                }
            }

            if (startTimer12)
            {
                if (timer12 >= 0)
                {
                    timer12 -= Time.deltaTime;
                    TimeOfFloor13.text = ((int)timer12).ToString() + "분 남음";
                }
                if ((int)timer12 <= 0)
                {
                    TimeOfFloor13.text = "임대료 받기";
                    buildCtrl.canEarn12 = true;
                    startTimer12 = false;
                    return;
                }
            }
        }
        
        // Timer2
        {
            if (startTimer20)
            {
                if (timer20 >= 0)
                {
                    timer20 -= Time.deltaTime;
                    TimeOfFloor21.text = ((int)timer20).ToString() + "분 남음";
                }
                if ((int)timer20 <= 0)
                {
                    TimeOfFloor21.text = "임대료 받기";
                    buildCtrl.canEarn20 = true;
                    startTimer20 = false;
                    return;
                }
            }

            if (startTimer21)
            {
                if (timer21 >= 0)
                {
                    timer21 -= Time.deltaTime;
                    TimeOfFloor22.text = ((int)timer21).ToString() + "분 남음";
                }
                if ((int)timer21 <= 0)
                {
                    TimeOfFloor22.text = "임대료 받기";
                    buildCtrl.canEarn21 = true;
                    startTimer21 = false;
                    return;
                }
            }

            if (startTimer22)
            {
                if (timer22 >= 0)
                {
                    timer22 -= Time.deltaTime;
                    TimeOfFloor23.text = ((int)timer22).ToString() + "분 남음";
                }
                if ((int)timer22 <= 0)
                {
                    TimeOfFloor23.text = "임대료 받기";
                    buildCtrl.canEarn22 = true;
                    startTimer22 = false;
                    return;
                }
            }

            if (startTimer23)
            {
                if (timer23 >= 0)
                {
                    timer23 -= Time.deltaTime;
                    TimeOfFloor24.text = ((int)timer23).ToString() + "분 남음";
                }
                if ((int)timer23 <= 0)
                {
                    TimeOfFloor24.text = "임대료 받기";
                    buildCtrl.canEarn23 = true;
                    startTimer23 = false;
                    return;
                }
            }
            if (startTimer24)
            {
                if (timer24 >= 0)
                {
                    timer24 -= Time.deltaTime;
                    TimeOfFloor25.text = ((int)timer24).ToString() + "분 남음";
                }
                if ((int)timer24 <= 0)
                {
                    TimeOfFloor25.text = "임대료 받기";
                    buildCtrl.canEarn24 = true;
                    startTimer24 = false;
                    return;
                }
            }
            if (startTimer25)
            {
                if (timer25 >= 0)
                {
                    timer25 -= Time.deltaTime;
                    TimeOfFloor26.text = ((int)timer25).ToString() + "분 남음";
                }
                if ((int)timer25 <= 0)
                {
                    TimeOfFloor26.text = "임대료 받기";
                    buildCtrl.canEarn25 = true;
                    startTimer25 = false;
                    return;
                }
            }
        }
        
        // Timer3
        {
            if (startTimer30)
            {
                if (timer30 >= 0)
                {
                    timer30 -= Time.deltaTime;
                    TimeOfFloor31.text = ((int)timer30).ToString() + "분 남음";
                }
                if ((int)timer30 <= 0)
                {
                    TimeOfFloor31.text = "임대료 받기";
                    buildCtrl.canEarn30 = true;
                    startTimer30 = false;
                    return;
                }
            }

            if (startTimer31)
            {
                if (timer31 >= 0)
                {
                    timer31 -= Time.deltaTime;
                    TimeOfFloor32.text = ((int)timer31).ToString() + "분 남음";
                }
                if ((int)timer31 <= 0)
                {
                    TimeOfFloor32.text = "임대료 받기";
                    buildCtrl.canEarn31 = true;
                    startTimer31 = false;
                    return;
                }
            }

            if (startTimer32)
            {
                if (timer32 >= 0)
                {
                    timer32 -= Time.deltaTime;
                    TimeOfFloor33.text = ((int)timer32).ToString() + "분 남음";
                }
                if ((int)timer32 <= 0)
                {
                    TimeOfFloor33.text = "임대료 받기";
                    buildCtrl.canEarn32 = true;
                    startTimer32 = false;
                    return;
                }
            }


            if (startTimer33)
            {
                if (timer33 >= 0)
                {
                    timer33 -= Time.deltaTime;
                    TimeOfFloor34.text = ((int)timer33).ToString() + "분 남음";
                }
                if ((int)timer33 <= 0)
                {
                    TimeOfFloor34.text = "임대료 받기";
                    buildCtrl.canEarn33 = true;
                    startTimer33 = false;
                    return;
                }
            }
            if (startTimer34)
            {
                if (timer34 >= 0)
                {
                    timer34 -= Time.deltaTime;
                    TimeOfFloor35.text = ((int)timer34).ToString() + "분 남음";
                }
                if ((int)timer34 <= 0)
                {
                    TimeOfFloor35.text = "임대료 받기";
                    buildCtrl.canEarn34 = true;
                    startTimer34 = false;
                    return;
                }
            }
            if (startTimer35)
            {
                if (timer35 >= 0)
                {
                    timer35 -= Time.deltaTime;
                    TimeOfFloor36.text = ((int)timer35).ToString() + "분 남음";
                }
                if ((int)timer35 <= 0)
                {
                    TimeOfFloor36.text = "임대료 받기";
                    buildCtrl.canEarn35 = true;
                    startTimer35 = false;
                    return;
                }
            }
        }
        
        // Timer4
        {
            if (startTimer40)
            {
                if (timer40 >= 0)
                {
                    timer40 -= Time.deltaTime;
                    TimeOfFloor41.text = ((int)timer40).ToString() + "분 남음";
                }
                if ((int)timer40 <= 0)
                {
                    TimeOfFloor41.text = "임대료 받기";
                    buildCtrl.canEarn40 = true;
                    startTimer40 = false;
                    return;
                }
            }

            if (startTimer41)
            {
                if (timer41 >= 0)
                {
                    timer41 -= Time.deltaTime;
                    TimeOfFloor42.text = ((int)timer41).ToString() + "분 남음";
                }
                if ((int)timer41 <= 0)
                {
                    TimeOfFloor42.text = "임대료 받기";
                    buildCtrl.canEarn41 = true;
                    startTimer41 = false;
                    return;
                }
            }
        }

    }
}
