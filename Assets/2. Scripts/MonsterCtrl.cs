using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    GameObject gameManager;
    public float health = 100;

    
    public bool isFound;
    Animator anim;
    Rigidbody2D rig;

    
    public IEnumerator ChasePlayer(Transform player)
    {
        while (isFound)
        {
            Vector3 dir = player.transform.position - transform.position;
            float dire = 0;
            if(dir.x > 0)
            {
                dire = 1;
            }
            else if (dir.x < 0)
            {
                dire = -1;
            }
            else
            {
                dire = 0;
            }
            // �����̱�
            // Move by rigidbody
            transform.position = transform.position + new Vector3(dire * Time.deltaTime, 0, 0);
            //rig.AddForce((dir.x - transform.position.x) * Time.deltaTime * 1 * Vector2.right, ForceMode2D.Impulse);

            // �̲������� ���� ����
            // If buttons are up, make sure it stops
            if (!isFound)
            {
                rig.velocity = new Vector2(0, rig.velocity.y);
            }

            // ������ ��
            if (dire == 0)
            {
                // �ִϸ��̼� �ٲٱ�
                // Stop running animation
                anim.SetBool("walk", false);
            }
            // ������ ��
            else
            {
                // �ִϸ��̼� �ٲٱ�
                // Start running animation
                anim.SetBool("walk", true);

                // ����
                if (dire > 0)
                {
                    // ĳ���� ���� �ٲٱ�
                    // seeing left
                    transform.localScale = new Vector3(-0.5f, 0.5f, 1);
                }

                // ������
                else if (dire < 0)
                {
                    // ĳ���� ���� �ٲٱ�
                    // seeing right
                    transform.localScale = new Vector3(0.5f, 0.5f, 1);
                }
            }
            if (!isFound)
            {
                break;
            }
            yield return null;
        }
        yield return null;
    }

    public IEnumerator StopChase()
    {
        // �̲������� ���� ����
        // make sure it stops
        rig.velocity = new Vector2(0, rig.velocity.y);

        // �ִϸ��̼� �ٲٱ�
        // Stop running animation
        anim.SetBool("walk", false);

        yield return null;
    }

    public void Damage(float scale)
    {
        if (health > 0)
        {
            health -= scale;
            anim.SetTrigger("damage");
        }
        else
        {
            gameManager.GetComponent<MoneyCtrl>().Earn(1000);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
