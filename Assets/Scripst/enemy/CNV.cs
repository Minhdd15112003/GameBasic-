using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CNV : MonoBehaviour
{
    public float phamViTocDo = 6f;

    private float viTriYBanDau;
    private float tocDo;

    void Start()
    {
        viTriYBanDau = 0;
        TaoTocDoNgauNhien();
    }

    void TaoTocDoNgauNhien()
    {
        tocDo = Random.Range(-phamViTocDo, phamViTocDo);
    }

    void Update()
    {

        float viTriYSau = transform.position.y + Time.deltaTime * tocDo;

        if (viTriYSau > viTriYBanDau + 3f)
        {
            viTriYSau = viTriYBanDau + 3f;
            TaoTocDoNgauNhien();
        }

        if (viTriYSau < viTriYBanDau - 3f)
        {
            viTriYSau = viTriYBanDau - 3f;
            TaoTocDoNgauNhien();
        }

        transform.position = new Vector2(transform.position.x, viTriYSau);

    }
}
