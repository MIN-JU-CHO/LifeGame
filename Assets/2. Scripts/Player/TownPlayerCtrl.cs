using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownPlayerCtrl : MonoBehaviour
{
    // 이동속도
    // speed
    float moveSpeed;

    // 플레이어 Animator
    // Animator of this player
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // 플레이어 Animator
        // get animator from itself
        anim = GetComponent<Animator>();

        // 이동속도
        // set speed
        moveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        // 수평 이동 값 가져오기 (-1, 0, 1)
        // Get value of moving horizontal
        float horMove = Input.GetAxisRaw("Horizontal");

        // 수직 이동 값 가져오기 (-1, 0, 1)
        // Get value of moving vertical
        float verMove = Input.GetAxisRaw("Vertical");

        // 움직이기
        // Move by transform
        transform.position += new Vector3(horMove * moveSpeed * Time.deltaTime, 0, 0);
        transform.position += new Vector3(0, verMove * moveSpeed * Time.deltaTime, 0);

        /*// 속도 제한하기
        // limiting speed
        if (rig.velocity.x > maxSpeed)       // right speed
        {
            rig.velocity = new Vector2(maxSpeed, rig.velocity.y);
        }
        else if (rig.velocity.x < -maxSpeed) //left speed
        {
            rig.velocity = new Vector2(-maxSpeed, rig.velocity.y);
        }*/

        /*// 미끄러지는 현상 방지
        // If buttons are up, make sure it stops
        if (Input.GetButtonUp("Horizontal"))
        {
            rig.velocity = new Vector2(0, rig.velocity.y);
        }*/

        // 멈췄을 때
        if (horMove == 0 && verMove == 0)
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
            if (horMove < 0)
            {
                // 캐릭터 방향 바꾸기
                // seeing left
                transform.localScale = new Vector3(-3, 3,1);
            }

            // 오른쪽
            else if (horMove > 0)
            {
                // 캐릭터 방향 바꾸기
                // seeing right
                transform.localScale = new Vector3(3, 3, 1);
            }
        }
    }
}
