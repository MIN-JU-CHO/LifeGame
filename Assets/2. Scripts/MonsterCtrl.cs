using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterCtrl : MonoBehaviour
{
    [HideInInspector]
    public int numOfThisMonster;

    GameObject gameManager;
    GameObject monsterManager;
    public float health = 100;
    public Image healthBar;

    
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
                // 애니메이션 바꾸기
                // Stop running animation
                anim.SetBool("walk", false);
            }
            // 움직일 때
            else
            {
                // 애니메이션 바꾸기
                // Start running animation
                anim.SetBool("walk", true);

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
        // 미끄러지는 현상 방지
        // make sure it stops
        rig.velocity = new Vector2(0, rig.velocity.y);

        // 애니메이션 바꾸기
        // Stop running animation
        anim.SetBool("walk", false);

        yield return null;
    }

    public void Damage(float scale)
    {
        if (health > 0)
        {
            health -= scale;
            anim.SetBool("walk", false);
            anim.SetTrigger("damage");
            healthBar.fillAmount = health / 100;
        }
        if (health <= 0)
        {
            gameManager.GetComponent<MoneyCtrl>().Earn(1000);
            monsterManager.GetComponent<MonsterManage>().DeleteMonster(numOfThisMonster);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").gameObject;
        monsterManager = GameObject.Find("MonsterManager").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
