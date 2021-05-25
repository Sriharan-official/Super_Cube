using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public Playermovement movement;
    public Gamemanager gamemanager;
    public Shakecam scam;
    public float restart = 1f;

    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            StartCoroutine(scam.Shake(.2f, .5f));


            FindObjectOfType<AudioManager>().Play("hit");
            gamemanager.Endgame();

        }
    }

}
