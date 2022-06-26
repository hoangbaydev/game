using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class round : MonoBehaviour
{
      public static round instance;
    // Start is called before the first frame update
    //random refab
    public float timeStep = 0;

    public GameObject game;
    public float timey = 0.05f;
    public float tran = 0;
    Player player;
    public float x = 0;
    public float y = 0;
    public bool updatePl = false;
    

        void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Debug.Log("instance");
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }
    void Start()
    {

        tran = game.transform.position.y;
        player = FindObjectOfType<Player>();
        x = player.transform.position.x;
        y = player.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (updatePl)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Time.timeScale = 1;
                updatePl = false;
                player.Rotation();
            }
        }
    }
    void FixedUpdate()
    {
        Debug.Log(sytem.instance.count+">>>>>>>>>>>>>>>>");
        switch (sytem.instance.count){
            case 1:
                muaxuan();
                break;
            case 2:
                muaha();
                Debug.Log("muaha");
                break;
            case 3:
                muathu();
                Debug.Log("muathu");
                break;
            case 4:
                muadong();
                Debug.Log("muadong");
                break;
        }
    }

    public void muaxuan()
    {
        if (player.checkpoint)
        {
            switch (player.checkpointCount)
            {
                case 0:
                    game.transform.position = new Vector3(0, 49.42f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    Time.timeScale = 0;
                    break;
                case 1:
                    game.transform.position = new Vector3(0, 15.91f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.08f;
                    Time.timeScale = 0;
                    break;
                case 2:
                    game.transform.position = new Vector3(0, -11.72f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    timey = 0.10f;
                    Time.timeScale = 0;
                    break;
                case 3:
                    game.transform.position = new Vector3(0, -42.25f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.11f;
                    Time.timeScale = 0;
                    break;
                case 4:
                    game.transform.position = new Vector3(0, -65.69f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = true;
                    updatePl = true;
                    timey = 0.12f;
                    Time.timeScale = 0;
                    break;
                case 5:
                    game.transform.position = new Vector3(0, -73.88f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.13f;
                    Time.timeScale = 0;
                    break;
                case 6:
                    game.transform.position = new Vector3(0, -127.7f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = true;
                    updatePl = true;
                    timey = 0.14f;
                    Time.timeScale = 0;
                    break;
            }
        }
        if (game.transform.position.y <= -145.5)
        {
            game.transform.position = new Vector3(0, -145.5f, 0);
            player.transform.position += new Vector3(x, +0.05f, 0);
        }
        else
            game.transform.position += new Vector3(0, -timey, 0);
    }
    public void muaha(){
         if(player.checkpoint)
        {
           switch(player.checkpointCount)
           {
               case 0:
                    game.transform.position = new Vector3(0f, -3.089f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    timey = 0.05f;
                    Time.timeScale = 0;
                   break;
                case 1:
                    game.transform.position = new Vector3(0f, -38.81f, 0);
                    player.transform.position = new Vector3(-1.1f, -1.18f, 0);
                    player.checkpoint = false;
                    player.left = true;
                    updatePl = true;
                    timey = 0.08f;
                    Time.timeScale = 0;
                    break;
                case 2 :  
                    game.transform.position = new Vector3(0f, -68.83f, 0);
                    player.transform.position = new Vector3(0.7f, -1.18f, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    player.left = true;
                    timey = 0.09f;
                    Time.timeScale = 0;
                    break;
                case 3:
                    game.transform.position = new Vector3(0f, -109.12f, 0);
                    player.transform.position = new Vector3(-0.1f, y, 0);
                    player.checkpoint = false;
                    player.left = true;
                    updatePl = true;
                    timey = 0.10f;
                    Time.timeScale = 0;
                    break;
                case 4:
                    game.transform.position = new Vector3(0f, -129.04f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = true;
                    updatePl = true;
                    timey = 0.12f;
                    Time.timeScale = 0;
                    break;
                case 5:
                    game.transform.position = new Vector3(0f, -145.7f, 0);
                    player.transform.position = new Vector3(0, -1.8f, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.13f;
                    Time.timeScale = 0;
                    break;
                case 6:
                    game.transform.position = new Vector3(0f, -167.19f, 0);
                    player.transform.position = new Vector3(0, -1.8f, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.14f;
                    Time.timeScale = 0;
                    break;
           }
        }
        if(game.transform.position.y <= -194.7){
            game.transform.position = new Vector3(0, -194.7f, 0);
            player.transform.position += new Vector3(x, +0.05f, 0);
        }else
            game.transform.position += new Vector3(0f, -timey, 0);  
    }

    private void muathu(){
        if(player.checkpoint)
        {
           switch(player.checkpointCount)
           {
               case 0:
                    game.transform.position = new Vector3(0f, 186.1f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    timey = 0.05f;
                    Time.timeScale = 0;
                   break;
                case 1:
                    game.transform.position = new Vector3(0f, 164.12f, 0);
                    player.transform.position = new Vector3(-0.8f, y, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.08f;
                    Time.timeScale = 0;
                    break;
                case 2 :  
                    game.transform.position = new Vector3(0f,136.53f, 0);
                    player.transform.position = new Vector3(-0.75f,y, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    player.left = false;
                    timey = 0.10f;
                    Time.timeScale = 0;
                    break;
                case 3:
                    game.transform.position = new Vector3(0f, 105.1f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.11f;
                    Time.timeScale = 0;
                    break;
                case 4:
                    game.transform.position = new Vector3(0f, 81.65f, 0);
                    player.transform.position = new Vector3(0.48f, -1.97f, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.12f;
                    Time.timeScale = 0;
                    break;
                case 5:
                    game.transform.position = new Vector3(0f, 57.2f, 0);
                    player.transform.position = new Vector3(0.48f, -1.94f, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.13f;
                    Time.timeScale = 0;
                    break;
                case 6:
                    game.transform.position = new Vector3(0f, 30.4f, 0);
                    player.transform.position = new Vector3(1.07f, -1.94f, 0);
                    player.checkpoint = false;
                    player.left = true;
                    updatePl = true;
                    timey = 0.14f;
                    Time.timeScale = 0;
                    break;
           }
        }
        if(game.transform.position.y <= -3.85){
            game.transform.position = new Vector3(0, -3.85f, 0);
            player.transform.position += new Vector3(x, +0.05f, 0);
        }else
            game.transform.position += new Vector3(0f, -timey, 0);  
    }
    private void muadong(){
        if(player.checkpoint)
        {
           switch(player.checkpointCount)
           {
               case 0:
                    game.transform.position = new Vector3(0f, 186.1f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    timey = 0.05f;
                    Time.timeScale = 0;
                   break;
                case 1:
                    game.transform.position = new Vector3(0f, 164.22f, 0);
                    player.transform.position = new Vector3(-0.8f, y, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.08f;
                    Time.timeScale = 0;
                    break;
                case 2 :  
                    game.transform.position = new Vector3(0f,136.65f, 0);
                    player.transform.position = new Vector3(-0.06f,y, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    player.left = false;
                    timey = 0.09f;
                    Time.timeScale = 0;
                    break;
                case 3:
                    game.transform.position = new Vector3(0f, 105.1f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.11f;
                    Time.timeScale = 0;
                    break;
                case 4:
                    game.transform.position = new Vector3(0f,82.3f, 0);
                    player.transform.position = new Vector3(-0.06f, -1.94f, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.12f;
                    Time.timeScale = 0;
                    break;
                case 5:
                    game.transform.position = new Vector3(0f,57.04f, 0);
                    player.transform.position = new Vector3(-0.06f, -1.94f, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.13f;
                    Time.timeScale = 0;
                    break;
                case 6:
                    game.transform.position = new Vector3(0f, 30.4f, 0);
                    player.transform.position = new Vector3(0.92f, -1.94f, 0);
                    player.checkpoint = false;
                    player.left = true;
                    updatePl = true;
                    timey = 0.14f;
                    Time.timeScale = 0;
                    break;
           }
        }
        if(game.transform.position.y <= -4.34){
            game.transform.position = new Vector3(0, -4.34f, 0);
            player.transform.position += new Vector3(x, +0.05f, 0);
        }else
            game.transform.position += new Vector3(0f, -timey, 0);  
    }
}
