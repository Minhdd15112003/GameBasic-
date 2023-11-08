using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform player;

    public float parallaxRatio;

    private Transform bgTransform;

    private Vector3 lastPlayerPosition;

    void Start()
    {
        bgTransform = transform; // Lấy transform component
        lastPlayerPosition = player.position; // Lưu vị trí ban đầu của nhân vật
    }

    void Update()
    {
        // Tính delta trên cả X và Y
        Vector3 delta = player.position - lastPlayerPosition;

        // Di chuyển background theo cả X và Y 
        bgTransform.position += new Vector3(delta.x, delta.y, 0) * parallaxRatio;

        // Cập nhật vị trí nhân vật mới
        lastPlayerPosition = player.position;
    }
}
