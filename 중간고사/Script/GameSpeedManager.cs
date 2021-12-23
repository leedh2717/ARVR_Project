using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSpeedManager : MonoBehaviour
{
    public Slider slider;
    float time = 0;
    public int stoneSpeed;
    public float stoneSpon;
    public bool ending;

    void Start()
    {
        ending = false;
    }


    void Update()
    {
        time += Time.deltaTime;

        switch ((int)time/10)
        {
            case 5:
                stoneSpeed = -6;
                stoneSpon = 1.8f;
                ending = false;
                break;
            case 4:
                stoneSpeed = -6;
                stoneSpon = 2f;
                ending = false;
                break;
            case 3:
                stoneSpeed = -5;
                stoneSpon = 2f;
                ending = false;
                break;
            case 2:
                stoneSpeed = -5;
                stoneSpon = 2.2f;
                ending = false;
                break;
            case 1:
                stoneSpeed = -4;
                stoneSpon = 2.6f;
                ending = false;
                break;
            case 0:
                stoneSpeed = -4;
                stoneSpon = 3f;
                ending = false;
                break;
            default:
                ending = true;
                break;
        }
        
        slider.value = time / 60;
    }
}