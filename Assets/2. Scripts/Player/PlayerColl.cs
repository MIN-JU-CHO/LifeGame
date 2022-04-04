using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColl : MonoBehaviour
{
    // Get PlayerCtrl, DoorCtrl script
    public PlayerCtrl playerCtrl;
    public DoorCtrl doorCtrl;

    // �浹�� �������� �� ȣ��
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

            // case of Door
            case "Door":
                // can open door
                doorCtrl.canOpen = true;

                break;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Depend on what kind of object that exit with player
        switch (collision.gameObject.tag)
        {
            // case of Door
            case "Door":
                // can't open door
                doorCtrl.canOpen = false;
                break;
        }
    }
}
