using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muaha : MonoBehaviour
{
    // Start is called before the first frame update
  public float timeStep =0;
   
   public GameObject game;
   public float timey = 0.05f;
    public float tran = 0;
    Player player;
    public float x = 0;
    public float y = 0;
    public  bool updatePl = false;
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
        if(updatePl){
            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
               Time.timeScale = 1;
               updatePl = false;
               player.Rotation();
            }
        }
    }
    void FixedUpdate()
    {
        if(player.checkpoint)
        {
           switch(player.checkpointCount)
           {
               case 0:
                    game.transform.position = new Vector3(0f, -3.089f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    Time.timeScale = 0;
                   break;
                case 1:
                    game.transform.position = new Vector3(0f, -38.81f, 0);
                    player.transform.position = new Vector3(-1.26f, -1.18f, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.08f;
                    Time.timeScale = 0;
                    break;
                case 2 :  
                    game.transform.position = new Vector3(0f, -68.83f, 0);
                    player.transform.position = new Vector3(0.61f, -1.18f, 0);
                    player.checkpoint = false;
                    updatePl = true;
                    player.left = true;
                    timey = 0.10f;
                    Time.timeScale = 0;
                    break;
                case 3:
                    game.transform.position = new Vector3(0f, -109.12f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = true;
                    updatePl = true;
                    timey = 0.11f;
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
                    game.transform.position = new Vector3(0f, -145.54f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = false;
                    updatePl = true;
                    timey = 0.13f;
                    Time.timeScale = 0;
                    break;
                case 6:
                    game.transform.position = new Vector3(0f, -166.6f, 0);
                    player.transform.position = new Vector3(x, y, 0);
                    player.checkpoint = false;
                    player.left = true;
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
}
