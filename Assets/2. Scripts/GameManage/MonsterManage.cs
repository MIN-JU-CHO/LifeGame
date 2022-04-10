using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManage : MonoBehaviour
{
    //[HideInInspector]
    //public int numOfMonsters = 0;

    GameObject[] monsters = new GameObject[3];
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        CreateMonster(0);
        CreateMonster(1);
        CreateMonster(2);
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("CheckMonsters", 1.0f);
    }


    //void CheckMonsters()
    //{
    //    if (numOfMonsters < 3)
    //    {
    //        CreateMonster();
    //    }
    //}


    void CreateMonster(int numOfMonsters)
    {
        monsters[numOfMonsters] = Instantiate(Resources.Load("Monster"), spawnPoints[numOfMonsters].position, Quaternion.identity) as GameObject;
        monsters[numOfMonsters].GetComponent<MonsterCtrl>().numOfThisMonster = numOfMonsters;
    }


    public void DeleteMonster(int numOfThisMonster)
    {
        monsters[numOfThisMonster] = null;
        StartCoroutine(WaitForIt(numOfThisMonster));
    }


    IEnumerator WaitForIt(int numOfThisMonster)
    {
        yield return new WaitForSeconds(1.0f);
        CreateMonster(numOfThisMonster);
    }
}
