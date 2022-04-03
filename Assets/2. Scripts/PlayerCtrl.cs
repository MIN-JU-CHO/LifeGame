using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // �̵��ӵ�
    // speed
    public float moveSpeed;

    // �÷��̾� Rigidbody
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
        // �̵� �� �������� (-1, 0, 1)
        // Get value of moving
        float move = Input.GetAxisRaw("Horizontal");

        // �����̱�
        // Move by rigidbody
        rig.AddForce(move * Time.deltaTime * moveSpeed * Vector2.right, ForceMode2D.Force);
    }
}
