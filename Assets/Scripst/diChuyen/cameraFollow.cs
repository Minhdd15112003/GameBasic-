using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    float smoothSpeed = 3;
    public Transform target;
    Vector3 offset;
    float lowY;

    void Start()
    {
        offset = transform.position - target.position;
        
        lowY = transform.position.y;
    }
    void Update()
    {
    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothSpeed * Time.deltaTime);

    }
}
