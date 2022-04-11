using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDetect : MonoBehaviour
{
    public MonsterCtrl monsterCtrl;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player":
                monsterCtrl.isFound = true;
                monsterCtrl.player = collision.transform;
                //monsterCtrl.ChasePlayer(collision.transform);
                break;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player":
                monsterCtrl.isFound = false;
                //monsterCtrl.StopChase();
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
