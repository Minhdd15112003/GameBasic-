using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float tocDo = 0.2f;
    private float huongDiChuyen = 1;
    private float viTriXBanDau;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        viTriXBanDau = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= viTriXBanDau + 2f)
        {
            huongDiChuyen = -1f;
        }

        if (transform.position.x <= viTriXBanDau - 2f)
        {
            huongDiChuyen = 1f;
        }

        rb.velocity = new Vector2(transform.localPosition.x, transform.localPosition.y) * tocDo* huongDiChuyen;
    }
}
