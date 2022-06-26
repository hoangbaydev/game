using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    // Start is called before the first frame update
    public static Event instance;
    public GameObject tapplaygame;
    public GameObject player;

    public GameObject pause;
    public GameObject gamestart;
    private bool check = true;
    private float time = 0.5f;
    public int count = 0;
    // Update is called once per frame

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }
    void Update()
    {
        if (Input.touchCount > 0 &&Input.GetTouch(0).phase == TouchPhase.Began && check)
        {
            check = false;
            tapplaygame.SetActive(false);
            gamestart.SetActive(true);
            Time.timeScale = 1;
            player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
        time -= Time.deltaTime;
        if(time < 0 ){
            gamestart.SetActive(false);
        }

    }

    //tạm dừng game
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pause.SetActive(true);
    }
    //tiếp tục game
    public void ContinueGame()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
    }
}
