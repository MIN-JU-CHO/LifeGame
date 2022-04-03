using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // 이동속도
    // speed
    public float moveSpeed;

    // 플레이어 Rigidbody
    // Rigidbody of this player
    Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        // 이동 값 가져오기 (-1, 0, 1)
        // Get value of moving
        float move = Input.GetAxisRaw("Horizontal");

        // 움직이기
        // Move by rigidbody
        rig.AddForce(move * Time.deltaTime * moveSpeed * Vector2.right, ForceMode2D.Force);
    }
}
