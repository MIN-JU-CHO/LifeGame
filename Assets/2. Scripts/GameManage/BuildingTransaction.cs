using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BuildingTransaction : MonoBehaviour
{
    // �Ӵ�� ���� ���� ��
    BuildingCtrl buildCtrl;

    
    // ��� ���� ġȯ ����
    Text CostOfBuilding1, LevelOfBuilding1;

    // ���� ���� ������
    int BuildingUpgrade1 = 500000, first = 1, second = 2;
    // ���� ������ ����
    Text TimeOfFloor1, TimeOfFloor2, TimeOfFloor3;
    Text CostOfFloor1, CostOfFloor2, CostOfFloor3;
    // ���� ���� �� ���� ������
    float timer00, timer01, timer02;
    int cost00 = 5000, cost01 = 3000, cost02 = 2000;

    public void SaveBuying(int i)
    {
        switch (i)
        {
            // ���� ����
            case 0:
                CostOfBuilding1.text = "���׷��̵�" + "\n" + BuildingUpgrade1.ToString() + " ��";
                BuildingUpgrade1 += 200000;
                LevelOfBuilding1.text = first.ToString() + "��� -> " + second.ToString() + "���";
                first++; second++;
                // �� �� �Ӵ�� ���
                CostOfFloor1.text = "�� �ð� ��" + "\n" + cost00.ToString() + "��";
                CostOfFloor2.text = "�� �ð� ��" + "\n" + cost01.ToString() + "��";
                CostOfFloor3.text = "�� �ð� ��" + "\n" + cost02.ToString() + "��";
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
            // ���� ����
            case 0:
                switch (floor)
                {
                    // 1�� ������
                    case 0:
                        timer00 = 60;
                        while (timer00 >= 0)
                        {
                            timer00 -= Time.deltaTime;
                            TimeOfFloor1.text = ((int)timer00).ToString() + "�� ����";

                            yield return null;
                            if ((int)timer00 <= 0)
                            {
                                TimeOfFloor1.text = "�Ӵ�� �ޱ�";
                                buildCtrl.canEarn00 = true;
                                yield break;
                            }
                        }
                        break;
                    // 2�� ������
                    case 1:
                        timer01 = 40;
                        while (timer01 >= 0)
                        {
                            timer01 -= Time.deltaTime;
                            TimeOfFloor2.text = ((int)timer01).ToString() + "�� ����";

                            yield return null;
                            if ((int)timer01 <= 0)
                            {
                                TimeOfFloor2.text = "�Ӵ�� �ޱ�";
                                buildCtrl.canEarn01 = true;
                                yield break;
                            }
                        }
                        break;
                    // 3�� ����
                    case 2:
                        timer02 = 50;
                        while (timer02 >= 0)
                        {
                            timer02 -= Time.deltaTime;
                            TimeOfFloor3.text = ((int)timer02).ToString() + "�� ����";

                            yield return null;
                            if ((int)timer02 <= 0)
                            {
                                TimeOfFloor3.text = "�Ӵ�� �ޱ�";
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

        // ó������ ���� ����
        CostOfBuilding1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("CostText").gameObject.GetComponent<Text>();
        LevelOfBuilding1 = GameObject.Find("DefaultUI").transform.Find("BuildingView").transform.Find("Building1").transform.Find("LevelText").gameObject.GetComponent<Text>();
        
        // �� ����
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
