using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetScroll : MonoBehaviour
{
     public float scrollSpeed = 0.05f;
//background dep :)
   private Renderer rend;
   private Vector2 offset;

    private float time=0;
    void Start()
    {
        rend = GetComponent<Renderer>();
        offset = rend.sharedMaterial.GetTextureOffset("_MainTex");
    }
// t thu sai cai material cua t xem sao
    void Update()
    {
        time += Time.deltaTime;
        if(time >=10){
            time = 0;
            scrollSpeed += 0.01f;
        }
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        offset = new Vector2(x, 0);
        rend.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
