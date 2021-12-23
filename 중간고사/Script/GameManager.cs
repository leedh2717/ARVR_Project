using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameExplain;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
        
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GameExplain()
    {
        if (!gameExplain.activeSelf)
        {
            gameExplain.SetActive(true);
        } else
        {
            gameExplain.SetActive(false);
        }
        
        
    }

    public void MoveMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

}
