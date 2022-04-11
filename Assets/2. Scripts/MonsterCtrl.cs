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
        // 플레이어를 못찾았거나, 공격받았을 때
        if (!isFound || player == null || isDamaged)
        {
            // 걷기 중지
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
        // 움직이기
        // Move by rigidbody
        transform.position = transform.position + new Vector3(dire * Time.deltaTime, 0, 0);
        //rig.AddForce((dir.x - transform.position.x) * Time.deltaTime * 1 * Vector2.right, ForceMode2D.Impulse);

        // 미끄러지는 현상 방지
        // If buttons are up, make sure it stops
        if (!isFound)
        {
            rig.velocity = new Vector2(0, rig.velocity.y);
        }

        // 멈췄을 때
        if (dire == 0)
        {
            // 걷기 중지
            // Stop running animation
            anim.SetBool("walk", false);
        }
        // 움직일 때
        else
        {
            // 걷기 중지
            // Stop running animation
            anim.SetBool("walk", false);

            // 맞고 있을 때
            if (isDamaged)
            {
                // 걷기 중지
                // Stop running animation
                anim.SetBool("walk", false);
                anim.SetTrigger("damage");
                return;
            }
            // 맞고 있지 않을 때
            else
            {
                // 걷기
                // Start running animation
                anim.SetBool("walk", true);
            }

            // 맞고 있을 때
            if (isDamaged)
            {
                // 걷기 중지
                // Stop running animation
                anim.SetBool("walk", false);
                anim.SetTrigger("damage");
            }

            // 왼쪽
            if (dire > 0)
            {
                // 캐릭터 방향 바꾸기
                // seeing left
                transform.localScale = new Vector3(-0.5f, 0.5f, 1);
            }

            // 오른쪽
            else if (dire < 0)
            {
                // 캐릭터 방향 바꾸기
                // seeing right
                transform.localScale = new Vector3(0.5f, 0.5f, 1);
            }
        }
        ////
    }

    public void StopChase()
    {
        // 미끄러지는 현상 방지
        // make sure it stops
        rig.velocity = new Vector2(0, rig.velocity.y);

        // 애니메이션 바꾸기
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
