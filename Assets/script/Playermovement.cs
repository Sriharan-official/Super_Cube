using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Forwardforce = 2000f;
    public float sideways = 500f;
    public Gamemanager gamemanager;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, Forwardforce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) 
        {
            rb.AddForce(sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            FindObjectOfType<AudioManager>().Play("side");
            
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            FindObjectOfType<AudioManager>().Play("side");
        }
        
        if(rb.position.y < -1)
        {
            gamemanager.Endgame();
        }
    }



}
