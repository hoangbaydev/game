using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sytem : MonoBehaviour
{
    // Start is called before the first frame update
    public static sytem instance;

    public int count = 0;
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
    void Start(){
        count = 0;
    }
}
