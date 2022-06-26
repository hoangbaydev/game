using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    //thay đổi trọng lực của player
    public Rigidbody2D rb;
    public bool left = true;

    public TMP_Text text_coin_pro;
    public TMP_Text score_text;
    public TMP_Text score_text2;
    public TMP_Text score_win;
    public TMP_Text coin_win;
    public TMP_Text coin_text;
    public TMP_Text life_text;
    public GameObject gameover;
    public GameObject player;
    public GameObject gamecomplete;

    public GameObject win;
    private bool isOnGround = true;
    public float posi;
    public float posiz;

    private int coin;
    private float score;
    private float speed = 1;
    private float timeStep = 0;
    private int life = 3;
    private bool check = false;
    public bool checkpoint = false;
    public int checkpointCount = 0;
    private AudioSource sounds;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sounds = GetComponent<AudioSource>();
        Time.timeScale = 0;
        score = 0.0f;
        coin = 0;
        life = 3;
        posi = player.transform.position.x;
        posiz = player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //lấy vị trí của player
        score += Time.deltaTime * 1000;
        //bỏ số thập phân
        score = (float)System.Math.Round(score, 0);
        score_text.text = score + "";
        life_text.text = life.ToString();
        if (!round.instance.updatePl)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && isOnGround)
            {
                left = !left;
                isOnGround = false;
                check = true;
                PlaySound("jump");
                Rotation();
            }
        }
        text_coin_pro.text = coin.ToString();
        if (check)
        {
            Rotation();
        }
    }
    public void Rotation()
    {
        if (left == true)
        {
            transform.eulerAngles = new Vector3(0, 0, -90);
            //trọng lực của player

            rb.AddForce(new Vector2(-40, 0));
        }

        else
        {
            transform.eulerAngles = new Vector3(180, 0, -270);
            //trọng lực của player
            rb.AddForce(new Vector2(40, 0));
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            isOnGround = true;

        }
        else
        {
            isOnGround = false;
        }
        if (col.gameObject.tag == "Die")
        {
            checkpoint = true;
            life--;
            if (life < 0)
            {
                Destroy(player);
                gameover.SetActive(true);
                gamecomplete.SetActive(false);
                Time.timeScale = 0;
                score_text2.text = score + "";
                coin_text.text = "Coin: " + coin;
                coin = 0;
                score = 0;
                life = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            coin++;
            PlaySound("coin");
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "spoin")
        {
            PlaySound("wingame");  
            round.instance.timey = 0.08f;
            Destroy(col.gameObject);
            checkpointCount = 1;
        }
        if (col.gameObject.tag == "spoin1")
        {
            round.instance.timey = 0.09f;
            PlaySound("wingame");
            Destroy(col.gameObject);
            checkpointCount = 2;
        }
        if (col.gameObject.tag == "spoin2")
        {
            round.instance.timey = 0.10f;
           
             PlaySound("wingame");
            Destroy(col.gameObject);
            checkpointCount = 3;
        }
        if (col.gameObject.tag == "spoin3")
        {
            round.instance.timey = 0.12f;
            PlaySound("wingame");
            Destroy(col.gameObject);
            checkpointCount = 4;
        }
        if (col.gameObject.tag == "spoin4")
        {
            round.instance.timey = 0.13f;
             PlaySound("wingame");
            Destroy(col.gameObject);
            checkpointCount = 5;
        }
        if (col.gameObject.tag == "spoin5")
        {
            round.instance.timey = 0.14f;   
            PlaySound("wingame");
            Destroy(col.gameObject);
            checkpointCount = 6;
        }
        if (col.gameObject.tag == "spoin6")
        {
            win.SetActive(true);
            coin_win.text = "Coin :" + coin.ToString();
            score_win.text = "Score : " +score.ToString() + "";
            Destroy(col.gameObject);
            Time.timeScale = 0;
            gamecomplete.SetActive(false);
            gameover.SetActive(false);
        }
    }

    //play sound
    private void PlaySound(string file)
    {
        sounds.PlayOneShot(Resources.Load<AudioClip>("Sounds/" + file));
    }

}
