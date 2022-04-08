using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BuildingTransaction : MonoBehaviour
{
    // 임대료 받을 때만 씀
    BuildingCtrl buildCtrl;

    
    // 모든 빌딩 치환 가능
    Text CostOfBuilding1, LevelOfBuilding1;

    // 제일 빌딩 데이터
    int BuildingUpgrade1 = 500000, first = 1, second = 2;
    // 제일 빌딩의 층만
    Text TimeOfFloor1, TimeOfFloor2, TimeOfFloor3;
    Text CostOfFloor1, CostOfFloor2, CostOfFloor3;
    // 제일 빌딩 각 층의 데이터
    float timer00, timer01, timer02;
    int cost00 = 5000, cost01 = 3000, cost02 = 2000;

    public void SaveBuying(int i)
    {
        switch (i)
        {
            // 제일 빌딩
            case 0:
                CostOfBuilding1.text = "업그레이드" + "\n" + BuildingUpgrade1.ToString() + " 원";
                BuildingUpgrade1 += 200000;
                LevelOfBuilding1.text = first.ToString() + "등급 -> " + second.ToString() + "등급";
                first++; second++;
                // 각 층 임대료 상승
                CostOfFloor1.text = "한 시간 당" + "\n" + cost00.ToString() + "원";
                CostOfFloor2.text = "한 시간 당" + "\n" + cost01.ToString() + "원";
                CostOfFloor3.text = "한 시간 당" + "\n" + cost02.ToString() + "원";
                cost00 += 1000;
                cost01 += 1000;
                cost02 += 1000;
                break;
        }
    }

    public IEnumerator TimeRunningOfEarn(int building, int floor)
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
                        while (timer00 >= 0)
                        {
                            timer00 -= Time.deltaTime;
                            TimeOfFloor1.text = ((int)timer00).ToString() + "분 남음";

                            yield return null;
                            if ((int)timer00 <= 0)
                            {
                                TimeOfFloor1.text = "임대료 받기";
                                buildCtrl.canEarn00 = true;
                                yield break;
                            }
                        }
                        break;
                    // 2층 독서실
                    case 1:
                        timer01 = 40;
                        while (timer01 >= 0)
                        {
                            timer01 -= Time.deltaTime;
                            TimeOfFloor2.text = ((int)timer01).ToString() + "분 남음";

                            yield return null;
                            if ((int)timer01 <= 0)
                            {
                                TimeOfFloor2.text = "임대료 받기";
                                buildCtrl.canEarn01 = true;
                                yield break;
                            }
                        }
                        break;
                    // 3층 ---
                    case 2:
                        timer02 = 50;
                        while (timer02 >= 0)
                        {
                            timer02 -= Time.deltaTime;
                            TimeOfFloor3.text = ((int)timer02).ToString() + "분 남음";

                            yield return null;
                            if ((int)timer02 <= 0)
                            {
                                TimeOfFloor3.text = "임대료 받기";
                                buildCtrl.canEarn02 = true;
                                yield break;
                            }
                        }
                        break;
                }
                yield return null;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        buildCtrl = GetComponent<BuildingCtrl>();

        // 처음에는 제일 빌딩
        CostOfBuilding1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("CostText").gameObject.GetComponent<Text>();
        LevelOfBuilding1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("LevelText").gameObject.GetComponent<Text>();
        
        // 층 관리
        TimeOfFloor1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor1").transform.Find("TimeText").gameObject.GetComponent<Text>();
        TimeOfFloor2 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor2").transform.Find("TimeText").gameObject.GetComponent<Text>();
        TimeOfFloor3 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor3").transform.Find("TimeText").gameObject.GetComponent<Text>();
        CostOfFloor1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor1").transform.Find("CostText").gameObject.GetComponent<Text>();
        CostOfFloor2 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor2").transform.Find("CostText").gameObject.GetComponent<Text>();
        CostOfFloor3 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("Floor3").transform.Find("CostText").gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
