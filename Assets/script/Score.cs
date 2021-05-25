using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoretxt;
    // Update is called once per frame
    void Update()
    {
        scoretxt.text = player.position.z.ToString("0");

    }
}
