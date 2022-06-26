using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offset : MonoBehaviour
{
    public float scrollSpeed = 0.1f;

   private Renderer rend;
   private Vector2 offset1;
    void Start()
    {
        rend = GetComponent<Renderer>();
        offset1 = rend.sharedMaterial.GetTextureOffset("_MainTex");
    }

    void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        offset1 = new Vector2(-x, 0);
        rend.sharedMaterial.SetTextureOffset("_MainTex", offset1);
    }
}
