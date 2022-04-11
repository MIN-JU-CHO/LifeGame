using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterCtrl : MonoBehaviour
{
    [HideInInspector]
    public int numOfThisMonster;

    MoneyCtrl moneyCtrl;
    MonsterManage monsterManager;
    public float health = 100;
    public Image healthBar;

    [HideInInspector]
    public Transform player;
    public bool isFound;
    public bool isDamaged;
    public Animator anim;
    Rigidbody2D rig;


    
    public void ChasePlayer(Transform player)
    {
        ////
        // �÷��̾ ��ã�Ұų�, ���ݹ޾��� ��
        if (!isFound || player == null || isDamaged)
        {
            // �ȱ� ����
            // Stop running animation
            anim.SetBool("walk", false);
            anim.SetTrigger("damage");
            return;
        }

        Vector3 dir = player.transform.position - transform.position;
        float dire = 0;
        if (dir.x > 0)
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
            // �ȱ� ����
            // Stop running animation
            anim.SetBool("walk", false);
        }
        // ������ ��
        else
        {
            // �ȱ� ����
            // Stop running animation
            anim.SetBool("walk", false);

            // �°� ���� ��
            if (isDamaged)
            {
                // �ȱ� ����
                // Stop running animation
                anim.SetBool("walk", false);
                anim.SetTrigger("damage");
                return;
            }
            // �°� ���� ���� ��
            else
            {
                // �ȱ�
                // Start running animation
                anim.SetBool("walk", true);
            }

            // �°� ���� ��
            if (isDamaged)
            {
                // �ȱ� ����
                // Stop running animation
                anim.SetBool("walk", false);
                anim.SetTrigger("damage");
            }

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
        ////
    }

    public void StopChase()
    {
        // �̲������� ���� ����
        // make sure it stops
        rig.velocity = new Vector2(0, rig.velocity.y);

        // �ִϸ��̼� �ٲٱ�
        // Stop running animation
        anim.SetBool("walk", false);
    }

    public void Damage(float scale)
    {
        isDamaged = true;
        if (health > 0)
        {
            health -= scale;
            anim.SetBool("walk", false);
            anim.SetTrigger("damage");
            healthBar.fillAmount = health / 100;
        }
        if (health <= 0)
        {
            anim.SetBool("walk", false);
            anim.SetTrigger("damage");
            moneyCtrl.Earn(1000);
            monsterManager.DeleteMonster(numOfThisMonster);
            Destroy(gameObject);
        }
        Invoke("ChangeStatus", 0.4f);
    }

    void ChangeStatus()
    {
        isDamaged = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
        moneyCtrl = GameObject.Find("GameManager").gameObject.GetComponent<MoneyCtrl>();
        monsterManager = GameObject.Find("MonsterManager").gameObject.GetComponent<MonsterManage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFound || isDamaged)
        {
            StopChase();
        }
        else if(!isDamaged)
        {
            ChasePlayer(player);
        }
    }
}
