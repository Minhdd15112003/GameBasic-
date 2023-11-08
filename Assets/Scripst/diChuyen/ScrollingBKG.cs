using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBKG : MonoBehaviour
{
    Renderer myRenderer;
    public float ScrollSpeed = 0.5f;
    float offset;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * ScrollSpeed;
        myRenderer.material.mainTextureOffset = new Vector2(offset, 0.01f);

    }
}

