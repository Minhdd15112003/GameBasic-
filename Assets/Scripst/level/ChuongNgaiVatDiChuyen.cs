using UnityEngine;

public class ChuongNgaiVatDiChuyen : MonoBehaviour
{

    public float tocDo = 3f;

    private float viTriYBanDau;
    private float huongDiChuyen = 1;

    void Start()
    {
        viTriYBanDau = transform.position.y;
    }

    void Update()
    {

        float viTriYSau = transform.position.y + Time.deltaTime * tocDo * huongDiChuyen;

        if (transform.position.y >= viTriYBanDau + 2f)
        {
            huongDiChuyen = -1f;
        }

        if (transform.position.y <= viTriYBanDau - 1f)
        {
            huongDiChuyen = 1f;
        }

        transform.position = new Vector2(transform.position.x, viTriYSau);

    }

}