using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMonster : MonoBehaviour
{
    [HideInInspector]
    public bool canOpen;

    public SpriteRenderer lightSquare;

    public IEnumerator Lighting()
    {
        yield return new WaitForSeconds(0.000001f);
        while (lightSquare.color.a < 1)
        {
            Color color = lightSquare.color;
            if (!canOpen)
            {
                color.a = 0;
                break;
            }
            else
            {
                color.a += .7f * Time.deltaTime;
            }
            lightSquare.color = color;
            yield return null;
        }
    }

    public IEnumerator Unlighting()
    {
        yield return new WaitForSeconds(0.000001f);
        while (lightSquare.color.a > 0)
        {
            Color color = lightSquare.color;
            if (canOpen)
            {
                color.a = 1;
                break;
            }
            else
            {
                color.a -= .7f * Time.deltaTime;
            }
            lightSquare.color = color;
            yield return null;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canOpen)
        {
            SceneManager.LoadScene("Monster");
        }
    }
}
