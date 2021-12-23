using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2D : MonoBehaviour
{
    public float jumpPower = 0;
    public AudioClip jumpSE; //20210107 추가
    public AudioClip damageSE; //20210107 추가
    public AudioClip eatSE; //20210107 추가
    AudioSource playSE; //20210107 추가

    int heartPoint = 3;
    public Text text;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        playSE = GetComponent<AudioSource>(); //20210107 추가
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //GetComponent<AudioSource>().Play(); //점프를 하면 소리가 난다.(2021.10.07추가)
            playSE.PlayOneShot(jumpSE); //20210107 추가

            if (transform.position.y > 3.8) GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            else GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpPower, 0);

            /*StopCoroutine(SharkSwim()); 코루틴함수 실행
            StartCoroutine(SharkSwim());*/

        }

        if (transform.position.y < -4.5f) transform.position = new Vector3(transform.position.x, -4.5f, 0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Home")
        {
            SceneManager.LoadScene("GameClear");
        }
        else if (other.tag == "Stone")
        {
            if (heartPoint > 1)
            {
                playSE.PlayOneShot(damageSE); //20210107 추가 
                text.text = "X " + --heartPoint;
                StartCoroutine(HitColorAnimation()); // 피격시 빨간색
                StartCoroutine(Invincibility()); // 무적                
            }else
            {
                SceneManager.LoadScene("GameOver");
            }
            
        } else if (other.tag == "HpUp")
        {
            playSE.PlayOneShot(eatSE);
            text.text = "X " + ++heartPoint;
            Destroy(other.gameObject);
        } else if (other.tag == "HpDown")
        {
            playSE.PlayOneShot(damageSE); //20210107 추가 
            text.text = "X " + --heartPoint;
            StartCoroutine(HitColorAnimation());
            StartCoroutine(Invincibility()); // 무적            
            Destroy(other.gameObject);
            if (heartPoint < 1)
            {
                SceneManager.LoadScene("GameOver");
            }
        }                     

    }

    /*IEnumerator SharkSwim() 상어 수영 점프 모션 초기화
    {
        animator.SetBool("isJump", true);
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("isJump", false);
    }*/

    private IEnumerator HitColorAnimation()
    {
        for (int i = 0; i < 5; i++)
        {
            spriteRenderer.color = Color.red;

            yield return new WaitForSeconds(0.1f);

            spriteRenderer.color = Color.white;

            yield return new WaitForSeconds(0.1f);
        }        

    }

    private IEnumerator Invincibility()
    {
        this.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(1f);
        this.GetComponent<Collider2D>().enabled = true;

    }

}