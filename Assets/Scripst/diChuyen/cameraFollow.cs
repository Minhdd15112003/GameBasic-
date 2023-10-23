using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothing;
    Vector3 offset;
    float lowY;
    void Start()
    {
        offset = transform.position - target.position;

        lowY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
