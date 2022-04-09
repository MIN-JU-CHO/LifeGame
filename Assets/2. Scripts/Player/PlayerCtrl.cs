using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // �̵��ӵ� �� ����
    // speed and max
    float moveSpeed, maxSpeed;

    // ���� Ƚ�� ����
    // num of jump (used by PlayerColl as well)
    [HideInInspector]
    public int jumpCount;

    // �÷��̾� Rigidbody
    // Rigidbody of this player
    Rigidbody2D rig;

    // �÷��̾� Animator
    // Animator of this player (used by PlayerColl as well)
    [HideInInspector]
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // �÷��̾� Rigidbody
        // get rigidbody from itself
        rig = GetComponent<Rigidbody2D>();

        // �÷��̾� Animator
        // get animator from itself
        anim = GetComponent<Animator>();

        // �̵��ӵ� �� ����
        // set speed and max
        moveSpeed = 20; maxSpeed = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        // �̵� �� �������� (-1, 0, 1)
        // Get value of moving
        float move = Input.GetAxisRaw("Horizontal");

        // �����̱�
        // Move by rigidbody
        rig.AddForce(move * Time.deltaTime * moveSpeed * Vector2.right, ForceMode2D.Impulse);

        // �ӵ� �����ϱ�
        // limiting speed
        if(rig.velocity.x > maxSpeed)       // right speed
        {
            rig.velocity = new Vector2(maxSpeed, rig.velocity.y);
        }
        else if(rig.velocity.x < -maxSpeed) //left speed
        {
            rig.velocity = new Vector2(-maxSpeed, rig.velocity.y);
        }

        // �̲������� ���� ����
        // If buttons are up, make sure it stops
        if (Input.GetButtonUp("Horizontal"))
        {
            rig.velocity = new Vector2(0, rig.velocity.y);
        }

        // ������ ��
        if (rig.velocity.x == 0)
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
            if (move < 0)
            {
                // ĳ���� ���� �ٲٱ�
                // seeing left
                transform.localScale = new Vector3(-1, 1, 1);
            }

            // ������
            else if (move > 0)
            {
                // ĳ���� ���� �ٲٱ�
                // seeing left
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
    
    void Jump()
    {
        // If jump key's down && it has enough count for jump
        if (Input.GetButtonDown("Jump") && jumpCount < 2)
        {
            // Add Force to top
            rig.AddForce(Vector2.up * 6, ForceMode2D.Impulse);

            // counting num of jump
            jumpCount++;

            // change animation as jump
            anim.SetBool("isJump", true);
        }
    }
}
