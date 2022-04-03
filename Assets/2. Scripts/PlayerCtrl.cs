using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // 이동속도 및 제한
    // speed and max
    float moveSpeed, maxSpeed;

    // 플레이어 Rigidbody
    // Rigidbody of this player
    Rigidbody2D rig;

    // 플레이어 Animator
    // Animator of this player
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // 플레이어 Rigidbody
        // get rigidbody from itself
        rig = GetComponent<Rigidbody2D>();

        // 플레이어 Animator
        // get animator from itself
        anim = GetComponent<Animator>();

        // 이동속도 및 제한
        // set speed and max
        moveSpeed = 20; maxSpeed = 5; 
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
        rig.AddForce(move * Time.deltaTime * moveSpeed * Vector2.right, ForceMode2D.Impulse);

        // 속도 제한하기
        // limiting speed
        if(rig.velocity.x > maxSpeed)       // right speed
        {
            rig.velocity = new Vector2(maxSpeed, rig.velocity.y);
        }
        else if(rig.velocity.x < -maxSpeed) //left speed
        {
            rig.velocity = new Vector2(-maxSpeed, rig.velocity.y);
        }

        // 미끄러지는 현상 방지
        // If buttons are up, make sure it stops
        if (Input.GetButtonUp("Horizontal"))
        {
            rig.velocity = new Vector2(0, rig.velocity.y);
        }

        // 멈췄을 때
        if (rig.velocity.x == 0)
        {
            // 애니메이션 바꾸기
            // Stop running animation
            anim.SetBool("isRun", false);
        }
        // 움직일 때
        else
        {
            // 애니메이션 바꾸기
            // Start running animation
            anim.SetBool("isRun", true);

            // 왼쪽
            if (move < 0)
            {
                // 캐릭터 방향 바꾸기
                // seeing left
                transform.localScale = new Vector3(-1, 1, 1);
            }

            // 오른쪽
            else if (move > 0)
            {
                // 캐릭터 방향 바꾸기
                // seeing left
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
}
