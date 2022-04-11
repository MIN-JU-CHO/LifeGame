using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BuildingTransaction : MonoBehaviour
{
    // �Ӵ�� ���� ���� ��
    BuildingCtrl buildCtrl;



    // ���� ���� ������
    int BuildingUpgrade0 = 500000, first0 = 1, second0 = 2;
    // ���� ������ ����
    public Text CostOfBuilding0, LevelOfBuilding0;
    public Text TimeOfFloor01, TimeOfFloor02, TimeOfFloor03;
    public Text CostOfFloor01, CostOfFloor02, CostOfFloor03;
    // ���� ���� �� ���� ������
    bool startTimer00, startTimer01, startTimer02;
    float timer00, timer01, timer02;
    int cost00 = 5000, cost01 = 3000, cost02 = 2000;
    
    // ���� ���� ������
    int BuildingUpgrade1 = 800000, first1 = 1, second1 = 2;
    // ���� ������ ����
    public Text CostOfBuilding1, LevelOfBuilding1;
    public Text TimeOfFloor11, TimeOfFloor12, TimeOfFloor13;
    public Text CostOfFloor11, CostOfFloor12, CostOfFloor13;
    // ���� ���� �� ���� ������
    bool startTimer10, startTimer11, startTimer12;
    float timer10, timer11, timer12;
    int cost10 = 7000, cost11 = 8000, cost12 = 6000;
    
    // ���� ���� ������
    int BuildingUpgrade2 = 800000, first2 = 1, second2 = 2;
    // ���� ������ ����
    public Text CostOfBuilding2, LevelOfBuilding2;
    public Text TimeOfFloor21, TimeOfFloor22, TimeOfFloor23, TimeOfFloor24, TimeOfFloor25, TimeOfFloor26;
    public Text CostOfFloor21, CostOfFloor22, CostOfFloor23, CostOfFloor24, CostOfFloor25, CostOfFloor26;
    // ���� ���� �� ���� ������
    bool startTimer20, startTimer21, startTimer22, startTimer23, startTimer24, startTimer25;
    float timer20, timer21, timer22, timer23, timer24, timer25;
    int cost20 = 6000, cost21 = 9000, cost22 = 10000, cost23 = 10000, cost24 = 10000, cost25 = 10000;
    
    // ���� ���� ������
    int BuildingUpgrade3 = 1000000, first3 = 1, second3 = 2;
    // ���� ������ ����
    public Text CostOfBuilding3, LevelOfBuilding3;
    public Text TimeOfFloor31, TimeOfFloor32, TimeOfFloor33, TimeOfFloor34, TimeOfFloor35, TimeOfFloor36;
    public Text CostOfFloor31, CostOfFloor32, CostOfFloor33, CostOfFloor34, CostOfFloor35, CostOfFloor36;
    // ���� ���� �� ���� ������
    bool startTimer30, startTimer31, startTimer32, startTimer33, startTimer34, startTimer35;
    float timer30, timer31, timer32, timer33, timer34, timer35;
    int cost30 = 20000, cost31 = 30000, cost32 = 15000, cost33 = 15000, cost34 = 15000, cost35 = 15000;
    
    // ���� ���� ������
    int BuildingUpgrade4 = 300000, first4 = 1, second4 = 2;
    // ���� ������ ����
    public Text CostOfBuilding4, LevelOfBuilding4;
    public Text TimeOfFloor41, TimeOfFloor42;
    public Text CostOfFloor41, CostOfFloor42;
    // ���� ���� �� ���� ������
    bool startTimer40, startTimer41;
    float timer40, timer41;
    int cost40 = 5000, cost41 = 3000;

    public void SaveBuying(int i)
    {
        switch (i)
        {
            // ���� ����
            case 0:
                {
                    CostOfBuilding0.text = "���׷��̵�" + "\n" + BuildingUpgrade0.ToString() + " ��";
                    BuildingUpgrade0 += 200000;
                    LevelOfBuilding0.text = first0.ToString() + "��� -> " + second0.ToString() + "���";
                    first0++; second0++;
                    // �� �� �Ӵ�� ���
                    CostOfFloor01.text = "�� �ð� ��" + "\n" + cost00.ToString() + "��";
                    CostOfFloor02.text = "�� �ð� ��" + "\n" + cost01.ToString() + "��";
                    CostOfFloor03.text = "�� �ð� ��" + "\n" + cost02.ToString() + "��";
                    cost00 += 1000;
                    cost01 += 1000;
                    cost02 += 1000;
                }
                break;

            // ���� ����
            case 1:
                {
                    CostOfBuilding1.text = "���׷��̵�" + "\n" + BuildingUpgrade1.ToString() + " ��";
                    BuildingUpgrade1 += 200000;
                    LevelOfBuilding1.text = first1.ToString() + "��� -> " + second1.ToString() + "���";
                    first1++; second1++;
                    // �� �� �Ӵ�� ���
                    CostOfFloor11.text = "�� �ð� ��" + "\n" + cost10.ToString() + "��";
                    CostOfFloor12.text = "�� �ð� ��" + "\n" + cost11.ToString() + "��";
                    CostOfFloor13.text = "�� �ð� ��" + "\n" + cost12.ToString() + "��";
                    cost10 += 2000;
                    cost11 += 2000;
                    cost12 += 2000;
                }
                break;
                
            // ���� ����
            case 2:
                {
                    CostOfBuilding2.text = "���׷��̵�" + "\n" + BuildingUpgrade2.ToString() + " ��";
                    BuildingUpgrade2 += 200000;
                    LevelOfBuilding2.text = first2.ToString() + "��� -> " + second2.ToString() + "���";
                    first2++; second2++;
                    // �� �� �Ӵ�� ���
                    CostOfFloor21.text = "�� �ð� ��" + "\n" + cost20.ToString() + "��";
                    CostOfFloor22.text = "�� �ð� ��" + "\n" + cost21.ToString() + "��";
                    CostOfFloor23.text = "�� �ð� ��" + "\n" + cost22.ToString() + "��";
                    CostOfFloor24.text = "�� �ð� ��" + "\n" + cost23.ToString() + "��";
                    CostOfFloor25.text = "�� �ð� ��" + "\n" + cost24.ToString() + "��";
                    CostOfFloor26.text = "�� �ð� ��" + "\n" + cost25.ToString() + "��";
                    cost20 += 2000;
                    cost21 += 2000;
                    cost22 += 2000;
                    cost23 += 2000;
                    cost24 += 2000;
                    cost25 += 2000;
                }
                break;
                
            // ���� ����
            case 3:
                {
                    CostOfBuilding3.text = "���׷��̵�" + "\n" + BuildingUpgrade3.ToString() + " ��";
                    BuildingUpgrade3 += 200000;
                    LevelOfBuilding3.text = first3.ToString() + "��� -> " + second3.ToString() + "���";
                    first3++; second3++;
                    // �� �� �Ӵ�� ���
                    CostOfFloor31.text = "�� �ð� ��" + "\n" + cost30.ToString() + "��";
                    CostOfFloor32.text = "�� �ð� ��" + "\n" + cost31.ToString() + "��";
                    CostOfFloor33.text = "�� �ð� ��" + "\n" + cost32.ToString() + "��";
                    CostOfFloor34.text = "�� �ð� ��" + "\n" + cost33.ToString() + "��";
                    CostOfFloor35.text = "�� �ð� ��" + "\n" + cost34.ToString() + "��";
                    CostOfFloor36.text = "�� �ð� ��" + "\n" + cost35.ToString() + "��";
                    cost30 += 3000;
                    cost31 += 3000;
                    cost32 += 3000;
                    cost33 += 3000;
                    cost34 += 3000;
                    cost35 += 3000;
                }
                break;

            // ���� ����
            case 4:
                {
                    CostOfBuilding4.text = "���׷��̵�" + "\n" + BuildingUpgrade4.ToString() + " ��";
                    BuildingUpgrade4 += 200000;
                    LevelOfBuilding4.text = first4.ToString() + "��� -> " + second4.ToString() + "���";
                    first4++; second4++;
                    // �� �� �Ӵ�� ���
                    CostOfFloor41.text = "�� �ð� ��" + "\n" + cost40.ToString() + "��";
                    CostOfFloor42.text = "�� �ð� ��" + "\n" + cost41.ToString() + "��";
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
            // ���� ����
            case 0:
                switch (floor)
                {
                    // 1�� ������
                    case 0:
                        timer00 = 60;
                        startTimer00 = true;
                        break;
                    // 2�� ������
                    case 1:
                        timer01 = 40;
                        startTimer01 = true;
                        break;
                    // 3�� ����
                    case 2:
                        timer02 = 50;
                        startTimer02 = true;
                        break;
                }
                break;

            // ���� ����
            case 1:
                switch (floor)
                {
                    // 1�� ������
                    case 0:
                        timer10 = 80;
                        startTimer10 = true;
                        break;
                    // 2�� ������
                    case 1:
                        timer11 = 90;
                        startTimer11 = true;
                        break;
                    // 3�� ����
                    case 2:
                        timer12 = 70;
                        startTimer12 = true;
                        break;
                }
                break;
                
            // ���� ����
            case 2:
                switch (floor)
                {
                    // 1�� ������
                    case 0:
                        timer20 = 60;
                        startTimer20 = true;
                        break;
                    // 2�� ������
                    case 1:
                        timer21 = 80;
                        startTimer21 = true;
                        break;
                    // 3�� ����
                    case 2:
                        timer22 = 110;
                        startTimer22 = true;
                        break;
                    // 4�� ����
                    case 3:
                        timer23 = 110;
                        startTimer23 = true;
                        break;
                    // 5�� ����
                    case 4:
                        timer24 = 110;
                        startTimer24 = true;
                        break;
                    // 6�� ����
                    case 5:
                        timer25 = 110;
                        startTimer25 = true;
                        break;
                }
                break;
                
            // ���� ����
            case 3:
                switch (floor)
                {
                    // 1�� ������
                    case 0:
                        timer30 = 120;
                        startTimer30 = true;
                        break;
                    // 2�� ������
                    case 1:
                        timer31 = 130;
                        startTimer31 = true;
                        break;
                    // 3�� ����
                    case 2:
                        timer32 = 70;
                        startTimer32 = true;
                        break;
                    // 3�� ����
                    case 3:
                        timer33 = 70;
                        startTimer33 = true;
                        break;
                    // 3�� ����
                    case 4:
                        timer34 = 70;
                        startTimer34 = true;
                        break;
                    // 3�� ����
                    case 5:
                        timer35 = 70;
                        startTimer35 = true;
                        break;
                }
                break;
                
            // ���� ����
            case 4:
                switch (floor)
                {
                    // 1�� ������
                    case 0:
                        timer40 = 60;
                        startTimer40 = true;
                        break;
                    // 2�� ������
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
        // 0�� ����
        {
            CostOfBuilding0 = buildCtrl.CostOfBuilding0;
            CostOfFloor01 = buildCtrl.EarnCost01;
            CostOfFloor02 = buildCtrl.EarnCost02;
            CostOfFloor03 = buildCtrl.EarnCost03;
        }
        // 1�� ����
        {
            CostOfBuilding1 = buildCtrl.CostOfBuilding1;
            CostOfFloor11 = buildCtrl.EarnCost11;
            CostOfFloor12 = buildCtrl.EarnCost12;
            CostOfFloor13 = buildCtrl.EarnCost13;
        }
        // 2�� ����
        {
            CostOfBuilding2 = buildCtrl.CostOfBuilding2;
            CostOfFloor21 = buildCtrl.EarnCost21;
            CostOfFloor22 = buildCtrl.EarnCost22;
            CostOfFloor23 = buildCtrl.EarnCost23;
            CostOfFloor24 = buildCtrl.EarnCost24;
            CostOfFloor25 = buildCtrl.EarnCost25;
            CostOfFloor26 = buildCtrl.EarnCost26;
        }
        // 3�� ����
        {
            CostOfBuilding3 = buildCtrl.CostOfBuilding3;
            CostOfFloor31 = buildCtrl.EarnCost31;
            CostOfFloor32 = buildCtrl.EarnCost32;
            CostOfFloor33 = buildCtrl.EarnCost33;
            CostOfFloor34 = buildCtrl.EarnCost34;
            CostOfFloor35 = buildCtrl.EarnCost35;
            CostOfFloor36 = buildCtrl.EarnCost36;
        }
        // 4�� ����
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
                    TimeOfFloor01.text = ((int)timer00).ToString() + "�� ����";
                }
                if ((int)timer00 <= 0)
                {
                    TimeOfFloor01.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor02.text = ((int)timer01).ToString() + "�� ����";
                }
                if ((int)timer01 <= 0)
                {
                    TimeOfFloor02.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor03.text = ((int)timer02).ToString() + "�� ����";
                }
                if ((int)timer02 <= 0)
                {
                    TimeOfFloor03.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor11.text = ((int)timer10).ToString() + "�� ����";
                }
                if ((int)timer10 <= 0)
                {
                    TimeOfFloor11.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor12.text = ((int)timer11).ToString() + "�� ����";
                }
                if ((int)timer11 <= 0)
                {
                    TimeOfFloor12.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor13.text = ((int)timer12).ToString() + "�� ����";
                }
                if ((int)timer12 <= 0)
                {
                    TimeOfFloor13.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor21.text = ((int)timer20).ToString() + "�� ����";
                }
                if ((int)timer20 <= 0)
                {
                    TimeOfFloor21.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor22.text = ((int)timer21).ToString() + "�� ����";
                }
                if ((int)timer21 <= 0)
                {
                    TimeOfFloor22.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor23.text = ((int)timer22).ToString() + "�� ����";
                }
                if ((int)timer22 <= 0)
                {
                    TimeOfFloor23.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor24.text = ((int)timer23).ToString() + "�� ����";
                }
                if ((int)timer23 <= 0)
                {
                    TimeOfFloor24.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor25.text = ((int)timer24).ToString() + "�� ����";
                }
                if ((int)timer24 <= 0)
                {
                    TimeOfFloor25.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor26.text = ((int)timer25).ToString() + "�� ����";
                }
                if ((int)timer25 <= 0)
                {
                    TimeOfFloor26.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor31.text = ((int)timer30).ToString() + "�� ����";
                }
                if ((int)timer30 <= 0)
                {
                    TimeOfFloor31.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor32.text = ((int)timer31).ToString() + "�� ����";
                }
                if ((int)timer31 <= 0)
                {
                    TimeOfFloor32.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor33.text = ((int)timer32).ToString() + "�� ����";
                }
                if ((int)timer32 <= 0)
                {
                    TimeOfFloor33.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor34.text = ((int)timer33).ToString() + "�� ����";
                }
                if ((int)timer33 <= 0)
                {
                    TimeOfFloor34.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor35.text = ((int)timer34).ToString() + "�� ����";
                }
                if ((int)timer34 <= 0)
                {
                    TimeOfFloor35.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor36.text = ((int)timer35).ToString() + "�� ����";
                }
                if ((int)timer35 <= 0)
                {
                    TimeOfFloor36.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor41.text = ((int)timer40).ToString() + "�� ����";
                }
                if ((int)timer40 <= 0)
                {
                    TimeOfFloor41.text = "�Ӵ�� �ޱ�";
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
                    TimeOfFloor42.text = ((int)timer41).ToString() + "�� ����";
                }
                if ((int)timer41 <= 0)
                {
                    TimeOfFloor42.text = "�Ӵ�� �ޱ�";
                    buildCtrl.canEarn41 = true;
                    startTimer41 = false;
                    return;
                }
            }
        }

    }
}
