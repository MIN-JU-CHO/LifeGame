using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class BuildingClick : MonoBehaviour
{
    BuildingCtrl buildCtrl;
    GameObject buildingUI, buildingScrollView, buildingView, scrollBar, building0, building1, building2, building3, building4;
    // Start is called before the first frame update
    void Start()
    {
        buildCtrl = GameObject.Find("GameManagerInTown").GetComponent<BuildingCtrl>();
        buildingUI = GameObject.FindGameObjectWithTag("BUI").transform.Find("BuildingUI").gameObject;
        buildingScrollView = buildingUI.transform.Find("BuildingView").transform.Find("Scroll View").gameObject;
        buildingView = buildingScrollView.transform.Find("Viewport").transform.Find("Content").gameObject;
        scrollBar = buildingScrollView.transform.Find("Scrollbar Vertical").gameObject;
        building0 = buildingView.transform.Find("Building0").gameObject;
        building1 = buildingView.transform.Find("Building1").gameObject;
        building2 = buildingView.transform.Find("Building2").gameObject;
        building3 = buildingView.transform.Find("Building3").gameObject;
        building4 = buildingView.transform.Find("Building4").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This is called when clicked
    private void OnMouseDown()
    {
        // 해당 오브젝트의 이름에서 숫자 뽑기
        int numOfBuilding = int.Parse(Regex.Replace(gameObject.name, @"\D", ""));
        buildCtrl.SetType(numOfBuilding);


        // 기본적으로 빌딩 창 모두 꺼놓기
        building0.SetActive(false);
        building1.SetActive(false);
        building2.SetActive(false);
        building3.SetActive(false);
        building4.SetActive(false);

        // 빌딩 UI 창 켜기
        buildingUI.SetActive(true);


        // 해당하는 빌딩의 창만 켜기
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
                // 스크롤 바 켜기
                scrollBar.SetActive(true);
                break;
            case 3:
                building3.SetActive(true);
                // 스크롤 바 켜기
                scrollBar.SetActive(true);
                break;
            case 4:
                building4.SetActive(true);
                break;
        }
    }
}
