using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_copy : MonoBehaviour
{
    public GameObject wallPrefab;

    public GameObject gsm;

    public float range;
    float delta = 0;

    void Update()
    {
        if (gsm.GetComponent<GameSpeedManager>().ending)
        {
            Destroy(gameObject);
        }

        delta += Time.deltaTime;
        if (delta > gsm.GetComponent<GameSpeedManager>().stoneSpon)
        {
            delta = 0;

            GameObject clone = Instantiate(wallPrefab);
            clone.transform.position = new Vector3(5, Random.Range(-range, range), 0);
        }
    }
}