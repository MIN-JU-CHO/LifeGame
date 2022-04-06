using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownPlayerCtrl : MonoBehaviour
{
    // �̵��ӵ�
    // speed
    float moveSpeed;

    // �÷��̾� Animator
    // Animator of this player
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // �÷��̾� Animator
        // get animator from itself
        anim = GetComponent<Animator>();

        // �̵��ӵ�
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
        // ���� �̵� �� �������� (-1, 0, 1)
        // Get value of moving horizontal
        float horMove = Input.GetAxisRaw("Horizontal");

        // ���� �̵� �� �������� (-1, 0, 1)
        // Get value of moving vertical
        float verMove = Input.GetAxisRaw("Vertical");

        // �����̱�
        // Move by transform
        transform.position += new Vector3(horMove * moveSpeed * Time.deltaTime, 0, 0);
        transform.position += new Vector3(0, verMove * moveSpeed * Time.deltaTime, 0);

        /*// �ӵ� �����ϱ�
        // limiting speed
        if (rig.velocity.x > maxSpeed)       // right speed
        {
            rig.velocity = new Vector2(maxSpeed, rig.velocity.y);
        }
        else if (rig.velocity.x < -maxSpeed) //left speed
        {
            rig.velocity = new Vector2(-maxSpeed, rig.velocity.y);
        }*/

        /*// �̲������� ���� ����
        // If buttons are up, make sure it stops
        if (Input.GetButtonUp("Horizontal"))
        {
            rig.velocity = new Vector2(0, rig.velocity.y);
        }*/

        // ������ ��
        if (horMove == 0 && verMove == 0)
        {
            // �ִϸ��̼� �ٲٱ�
            // Stop running animation
            anim.SetBool("isRun", false);
        }
        // ������ ��
        else
        {
            // �ִϸ��̼� �ٲٱ�
            // Start running animation
            anim.SetBool("isRun", true);

            // ����
            if (horMove < 0)
            {
                // ĳ���� ���� �ٲٱ�
                // seeing left
                transform.localScale = new Vector3(-3, 3,1);
            }

            // ������
            else if (horMove > 0)
            {
                // ĳ���� ���� �ٲٱ�
                // seeing right
                transform.localScale = new Vector3(3, 3, 1);
            }
        }
    }
}
