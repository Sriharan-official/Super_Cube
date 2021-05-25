using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public Gamemanager gamemanager;
    public void OnTriggerEnter()
    {
        Debug.Log("End");
        gamemanager.complete();
    }

   
}
