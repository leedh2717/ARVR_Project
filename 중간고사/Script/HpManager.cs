using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpManager : MonoBehaviour
{
    float upDelta = 0;
    float downDelta = 0;

    public GameObject[] Go;

    void Start()
    {
        
    }

    void Update()
    {
        upDelta += Time.deltaTime;
        if (upDelta > 13.7f)
        {
            upDelta = 0;

            GameObject clone = Instantiate(Go[0]);
            clone.transform.position = new Vector3(9, Random.Range(-4, 4), 0);
        }

        downDelta += Time.deltaTime;
        if (downDelta > 3)
        {
            downDelta = 0;

            GameObject clone = Instantiate(Go[1]);
            clone.transform.position = new Vector3(9, Random.Range(-4, 4), 0);
        }

    }
}
