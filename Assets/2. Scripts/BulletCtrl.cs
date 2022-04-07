using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Enemy"|| collision.gameObject.tag == "Bottom")
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<MonsterCtrl>().Damage(10);
        }
    }
}
