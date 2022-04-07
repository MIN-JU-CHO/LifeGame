using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownPlayerColl : MonoBehaviour
{
    // Get PlayerCtrl, DoorCtrl script
    public TownPlayerCtrl playerCtrl;
    public GotoMonster gotomon;

    // Called When it starts to trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Depend on what kind of object that triggered with player
        switch (collision.gameObject.tag)
        {
            // case of MonDoor
            case "MonDoor":
                // can open door
                gotomon.canOpen = true;
                StartCoroutine(gotomon.Lighting());
                break;
        }
    }


    // Called When it ends to trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Depend on what kind of object that exited with player
        switch (collision.gameObject.tag)
        {
            // case of MonDoor
            case "MonDoor":
                // can't open door
                gotomon.canOpen = false;
                StartCoroutine(gotomon.Unlighting());
                break;
        }
    }
}
