using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_move : MonoBehaviour
{
    public float Wall_speed = 0;
    GameObject gsm;

    void Start()
    {
        Destroy(gameObject, 10f);
        gsm = GameObject.Find("GameSpeedManager");
    }


    void Update()
    {
        transform.Translate(gsm.GetComponent<GameSpeedManager>().stoneSpeed * Time.deltaTime, 0, 0);
    }

    public void DestroyStone()
    {
        Destroy(gameObject);
    }

}