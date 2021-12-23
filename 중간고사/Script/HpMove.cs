using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpMove : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    void Update()
    {
        transform.Translate(-8*Time.deltaTime, 0, 0);
    }
}
