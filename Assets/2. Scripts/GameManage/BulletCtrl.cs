using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    LevelCtrl levelCtrl;

    private void Start()
    {
        levelCtrl = GameObject.Find("GameManager").GetComponent<LevelCtrl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Enemy"|| collision.gameObject.tag == "Bottom")
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<MonsterCtrl>().Damage(levelCtrl.GetLevel() * 5);
        }
    }
}
