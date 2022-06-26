using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScene : MonoBehaviour
{
    public static MenuScene instance;
    // Start is called before the first frame update
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

    public void PlayGame()
    {
        SceneManager.LoadScene("SceneBC");
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("ScenePlay");
    }
    public void muaha()
    {
         sytem.instance.count = 2;
         SceneManager.LoadScene("muaha");
    }
    public void muaxuan()
    {
        sytem.instance.count = 1;
        SceneManager.LoadScene("muaxuan");
    }
    public void muathu()
    {sytem.instance.count = 3;
        SceneManager.LoadScene("muathu");
    }
    public void muadong()
    {
        sytem.instance.count = 4;
        SceneManager.LoadScene("muadong");
        
    }
    public void back()
    {
        SceneManager.LoadScene("ScenePlay");
    }
}
