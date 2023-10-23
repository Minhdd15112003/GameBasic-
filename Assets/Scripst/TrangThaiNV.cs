using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrangThaiNV : MonoBehaviour
{
    public Transform nguoiChoiTransform;
    public Text oTenNgChoi;
    
    public TextMeshProUGUI oMau;
    public float mauBanDau = 100;
    private float mauHienTai;

    public TextMeshProUGUI oDiem;
    public float diemBanDau = 0;
    private float diemHienTai;
    public thanhMau thanhmau;
    public GameObject bloodEffect;

    public AudioSource aus;
    public AudioClip hurtSound;
    public AudioClip healSound;

    void Start()
    {
        mauHienTai = PlayerPrefs.GetFloat("MauNgChoi", mauBanDau);
        diemHienTai = PlayerPrefs.GetFloat("DiemNgChoi", diemBanDau);
        oTenNgChoi.text = PlayerPrefs.GetString("TenNgChoi", "NgChoi");
        CapNhatGiaoDien();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.WorldToScreenPoint(nguoiChoiTransform.position);
        pos.y += 30f;
        oTenNgChoi.transform.position = pos;

        diemHienTai = Mathf.Max(diemHienTai, 0);
        mauHienTai = Mathf.Min(mauHienTai, 100);
        CapNhatGiaoDien();

    }

    private void OnMouseDown()
    {
        mauHienTai -= 10;
       PlayerPrefs.SetFloat("MauNgChoi", mauHienTai);
        if (mauHienTai <= 0)
        {
            makeDead();
        }

        //diemHienTai -= 10;
        //PlayerPrefs.SetFloat("DiemNgChoi", diemHienTai);
        CapNhatGiaoDien();
    }

    
    public void AddScore(int score)
    {
     
        diemHienTai += score;
        PlayerPrefs.SetFloat("DiemNgChoi", diemHienTai);
        CapNhatGiaoDien();
    }
    public void addDamage(float damage)
    {
        if (damage <= 0)
            return;
        mauHienTai -= damage;
        PlayerPrefs.SetFloat("MauNgChoi", mauHienTai);
        if (mauHienTai <= 0)
        {
            makeDead();
        }
        if (aus && hurtSound != null)
        {
            aus.PlayOneShot(hurtSound);
        }
        CapNhatGiaoDien();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("heart"))
        {
            mauHienTai += 100;
            PlayerPrefs.SetFloat("MauNgChoi", mauHienTai);
            Destroy(collision.gameObject,1);
            if (aus && healSound != null)
            {
                aus.PlayOneShot(healSound);
            }
            CapNhatGiaoDien();
        }
    }

    private void makeDead()
    {
        SceneManager.LoadScene(4);
        PlayerPrefs.Save();
        diemHienTai = 0;
        mauHienTai += 100;
        PlayerPrefs.SetFloat("DiemNgChoi", diemHienTai);
        PlayerPrefs.SetFloat("MauNgChoi", mauHienTai);
        Instantiate(bloodEffect,transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void CapNhatGiaoDien()
    {
        oMau.text = "HP: " + mauHienTai.ToString();
        oDiem.text = "" + diemHienTai.ToString();
        float tiLeMau = mauHienTai / mauBanDau;
        thanhmau.CapNhatThanhMau(tiLeMau);
    }

}
