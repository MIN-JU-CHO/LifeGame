using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColl : MonoBehaviour
{
    // Get PlayerCtrl, DoorCtrl script
    public PlayerCtrl playerCtrl;
    public DoorCtrl doorCtrl;

    // 충돌을 시작했을 때 호출
    // Called When it starts to collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Depend on what kind of object that collided with player
        switch (collision.gameObject.tag)
        {
            // case of Bottom
            case "Bottom":

                // initialize jump counting
                playerCtrl.jumpCount = 0;

                // turn off jump animation
                playerCtrl.anim.SetBool("isJump", false);
                break;

        }
    }

    // Called When it starts to trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Depend on what kind of object that triggered with player
        switch (collision.gameObject.tag)
        {
            // case of Door
            case "Door":
                // can open door
                doorCtrl.canOpen = true;
                StartCoroutine(doorCtrl.Lighting());
                break;
        }
    }


    // Called When it ends to trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Depend on what kind of object that exited with player
        switch (collision.gameObject.tag)
        {
            // case of Door
            case "Door":
                // can't open door
                doorCtrl.canOpen = false;
                StartCoroutine(doorCtrl.Unlighting());
                break;
        }
    }
}
