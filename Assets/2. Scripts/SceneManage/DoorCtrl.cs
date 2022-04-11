using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCtrl : MonoBehaviour
{
    [HideInInspector]
    public bool canOpen;
    
    public SpriteRenderer lightSquare;

    Scene scene;

    // ���� ������ �� ����
    // make furnitures unable to see
    [HideInInspector]
    public ShopCtrl shopCtrl;

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
                color.a += 1f * Time.deltaTime;
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
                color.a -= 1f * Time.deltaTime;
            }
            lightSquare.color = color;
            yield return null;
        }
    }

    private void Start()
    {
        shopCtrl = GameObject.Find("GameManager").GetComponent<ShopCtrl>();
    }

    private void OnMouseDown()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Home")
        {
            if (canOpen)
            {
                SceneManager.LoadScene("Town");
                // When trying to exit home, hide furnitures bought
                if (shopCtrl.cactus != null)
                {
                    (shopCtrl.cactus as GameObject).SetActive(false);
                }
                if (shopCtrl.armchair != null)
                {
                    (shopCtrl.armchair as GameObject).SetActive(false);
                }
                if (shopCtrl.book != null)
                {
                    (shopCtrl.book as GameObject).SetActive(false);
                }
                if (shopCtrl.Cup != null)
                {
                    (shopCtrl.Cup as GameObject).SetActive(false);
                }
                if (shopCtrl.Grass != null)
                {
                    (shopCtrl.Grass as GameObject).SetActive(false);
                }
                if (shopCtrl.Tree != null)
                {
                    (shopCtrl.Tree as GameObject).SetActive(false);
                }
                if (shopCtrl.Furniture != null)
                {
                    (shopCtrl.Furniture as GameObject).SetActive(false);
                }
                if (shopCtrl.Picture1 != null)
                {
                    (shopCtrl.Picture1 as GameObject).SetActive(false);
                }
                if (shopCtrl.Picture2 != null)
                {
                    (shopCtrl.Picture2 as GameObject).SetActive(false);
                }
                if (shopCtrl.Sofa != null)
                {
                    (shopCtrl.Sofa as GameObject).SetActive(false);
                }
                if (shopCtrl.Table != null)
                {
                    (shopCtrl.Table as GameObject).SetActive(false);
                }
            }
        }

        else if (scene.name == "Monster")
        {
            if (canOpen)
            {
                // When trying to exit Monster, this inactivate player's shooting
                if (GameObject.Find("Wizard") != null)
                {
                    GameObject.Find("Wizard").GetComponent<PlayerShooting>().canShoot = false;
                }

                SceneManager.LoadScene("Home");

                //When trying to go home, show furnitures bought
                if (shopCtrl.cactus != null)
                {
                    (shopCtrl.cactus as GameObject).SetActive(true);
                }
                if (shopCtrl.armchair != null)
                {
                    (shopCtrl.armchair as GameObject).SetActive(true);
                }
                if (shopCtrl.book != null)
                {
                    (shopCtrl.book as GameObject).SetActive(true);
                }
                if (shopCtrl.Cup != null)
                {
                    (shopCtrl.Cup as GameObject).SetActive(true);
                }
                if (shopCtrl.Grass != null)
                {
                    (shopCtrl.Grass as GameObject).SetActive(true);
                }
                if (shopCtrl.Tree != null)
                {
                    (shopCtrl.Tree as GameObject).SetActive(true);
                }
                if (shopCtrl.Furniture != null)
                {
                    (shopCtrl.Furniture as GameObject).SetActive(true);
                }
                if (shopCtrl.Picture1 != null)
                {
                    (shopCtrl.Picture1 as GameObject).SetActive(true);
                }
                if (shopCtrl.Picture2 != null)
                {
                    (shopCtrl.Picture2 as GameObject).SetActive(true);
                }
                if (shopCtrl.Sofa != null)
                {
                    (shopCtrl.Sofa as GameObject).SetActive(true);
                }
                if (shopCtrl.Table != null)
                {
                    (shopCtrl.Table as GameObject).SetActive(true);
                }
            }
        }
    }
}
