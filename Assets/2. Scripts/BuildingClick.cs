using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class BuildingClick : MonoBehaviour
{
    BuildingCtrl buildCtrl;
    GameObject buildingUI, buildingView, building0, building1, building2, building3, building4;
    // Start is called before the first frame update
    void Start()
    {
        buildCtrl = GameObject.Find("GameManagerInTown").GetComponent<BuildingCtrl>();
        buildingUI = GameObject.FindGameObjectWithTag("BUI").transform.Find("BuildingUI").gameObject;
        buildingView = buildingUI.transform.Find("BuildingView").gameObject;
        building0 = buildingView.transform.Find("Scroll View0").gameObject;
        building1 = buildingView.transform.Find("Scroll View1").gameObject;
        building2 = buildingView.transform.Find("Scroll View2").gameObject;
        building3 = buildingView.transform.Find("Scroll View3").gameObject;
        building4 = buildingView.transform.Find("Scroll View4").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This is called when clicked
    private void OnMouseDown()
    {
        // �ش� ������Ʈ�� �̸����� ���� �̱�
        int numOfBuilding = int.Parse(Regex.Replace(gameObject.name, @"\D", ""));
        buildCtrl.SetType(numOfBuilding);


        // �⺻������ ���� â ��� ������
        building0.SetActive(false);
        building1.SetActive(false);
        building2.SetActive(false);
        building3.SetActive(false);
        building4.SetActive(false);

        // ���� UI â �ѱ�
        buildingUI.SetActive(true);


        // �ش��ϴ� ������ â�� �ѱ�
        switch (numOfBuilding)
        {
            case 0:
                building0.SetActive(true);
                break;
            case 1:
                building1.SetActive(true);
                break;
            case 2:
                building2.SetActive(true);
                break;
            case 3:
                building3.SetActive(true);
                break;
            case 4:
                building4.SetActive(true);
                break;
        }
    }
}
