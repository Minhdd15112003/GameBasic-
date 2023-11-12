using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnPlay : MonoBehaviour
{
    public InputField oNhapTenNgChoi;

    private void Start()
    {
       
    }

    public void level1()
    {
        string tenNgChoi = oNhapTenNgChoi.text;
        PlayerPrefs.SetString("TenNgChoi", tenNgChoi);
        SceneManager.LoadScene(1);
        PlayerPrefs.Save();
    }

    public void level2()
    {
        string tenNgChoi = oNhapTenNgChoi.text;
        PlayerPrefs.SetString("TenNgChoi", tenNgChoi);
        SceneManager.LoadScene(2);
        PlayerPrefs.Save();
    }

    public void level3()
    {
        string tenNgChoi = oNhapTenNgChoi.text;
        PlayerPrefs.SetString("TenNgChoi", tenNgChoi);
        SceneManager.LoadScene(2);
        PlayerPrefs.Save();
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
    // Start is called before the first frame update
  