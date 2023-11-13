using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBKG : MonoBehaviour
{
    Renderer myRenderer;
    public float ScrollSpeed = 0.5f;
    float offset;
    public diChuyen character;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        character = GameObject.Find("nguoiChoi").GetComponent<diChuyen>();
    }

    // Update is called once per frame
   public void Update()
    {
        if (character != null && character.isMoving)
        {
            offset += Time.deltaTime * ScrollSpeed;
            myRenderer.material.mainTextureOffset = new Vector2(offset, 0.01f);
        }
        
    }
}

