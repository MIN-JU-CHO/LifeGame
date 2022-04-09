using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerShooting : MonoBehaviour
{
    // Is it able to shoot? or Mouse clicked the button to go home
    public bool canShoot = true;

    // For Geting 'settingView' UI active
    GameObject settingView;
    // Player's animation and direction
    Animator anim;
    float dir;
    // Shooting Power
    public float FirePower;
    // Start is called before the first frame update
    void Start()
    {
        settingView = GameObject.Find("DefaultUI").transform.Find("SettingView").gameObject;
        anim = GetComponent<Animator>();
        canShoot = true;
    }
    // Update is called once per frame
    void Update()
    {
        // 총을 쐈다면 + UI 위에 마우스 없다면
        if(Input.GetButtonDown("Fire1") && !EventSystem.current.IsPointerOverGameObject()
            && Time.timeScale!=0 && !settingView.activeSelf && canShoot)
            {
                // 캐릭터 방향
                if (transform.localScale.x > 0)
                {
                    dir = 1;
                }
                else if (transform.localScale.x < 0)
                {
                    dir = -1;
                }

                GameObject bullet = Instantiate(Resources.Load("Bullet"),
                    transform.position + new Vector3(dir * 2f , 2, 0), Quaternion.identity) as GameObject;

                anim.SetTrigger("attack");

                bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * dir * FirePower, ForceMode2D.Impulse);

                Destroy(bullet, 3);
            }
    }
}
