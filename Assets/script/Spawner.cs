using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int pos = 1;
    public Transform Obstacle;
    //1
    //public Transform End;
    public GameObject[] obsprefab;
    public float levelwidth = 4.5f;

    public void Update()
    {
       
        //Transform End = GameObject.Find("Cube").GetComponent<Transform>();
        //2
        //GameObject gam = GameObject.Find("Cube");
        //Transform End = gam.GetComponent<Transform>();
        //3
        Transform End = FindObjectOfType<Endtrigger>().GetComponent<Transform>();


        if (Obstacle.position.z < End.position.z - 80f )
        {
           
            Vector3 newpos = Obstacle.position;
            

            newpos.z += 20f;
            newpos.x = Random.Range(-levelwidth,levelwidth);

            int rand = Random.Range(0, obsprefab.Length);
            GameObject newcircle = Instantiate(obsprefab[rand], newpos, Quaternion.identity);
            Obstacle = newcircle.transform;
        }


    }
}
