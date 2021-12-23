using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    GameObject gsm;

    void Start()
    {
        gsm = GameObject.Find("GameSpeedManager");
    }

    void Update()
    {
        if (gsm.GetComponent<GameSpeedManager>().ending)
        {
            transform.Translate(-3 * Time.deltaTime, 0, 0);
        }
                
    }
}
