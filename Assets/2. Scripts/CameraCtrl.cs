using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    // Player
    public Transform player;

    // Camera moving speed
    float cameraSpeed = 2f;

    // Position and size of camera
    public Vector3 areaCenter, areaSize;

    // Half size of camera
    float heightHalf, widthHalf;

    // Start is called before the first frame update
    void Start()
    {
        // Get half size of camera
        heightHalf = Camera.main.orthographicSize;
        widthHalf = Screen.width * heightHalf / Screen.height;
    }

    // Update is called once per frame
    void LateUpdate()   // Called after Update()
    {
        // Saving player's position (Except z from itself)
        Vector3 target = new Vector3(player.position.x + 5f, player.position.y, transform.position.z);

        // Following player slowly
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * cameraSpeed);

        // 영역 가로 절반 - 카메라 가로 절반 = 두 가로 절반의 차이(비율)
        float disX = areaSize.x * 0.5f - widthHalf;

        // 영역 세로 절반 - 카메라 세로 절반 = 두 세로 절반의 차이(비율)
        float disY = areaSize.y * 0.5f - heightHalf;

        // Clamp camera's position
        float clampX = Mathf.Clamp(transform.position.x, areaCenter.x - disX, areaCenter.x + disX);
        float clampY = Mathf.Clamp(transform.position.y, areaCenter.y - disY, areaCenter.y + disY);

        // Apply clamp
        transform.position = new Vector3(clampX, clampY, transform.position.z);
    }

    // Making Gizmos
    private void OnDrawGizmos()
    {
        // Change gizmos color
        Gizmos.color = Color.black;

        // Drawing cube
        Gizmos.DrawWireCube(areaCenter, areaSize);
    }
}
