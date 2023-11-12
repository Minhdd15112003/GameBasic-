using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thanhMau : MonoBehaviour
{
    // Start is called before the first frame update

    public Image thanhmau;

    public void CapNhatThanhMau(float tiLe)
    {
        thanhmau.fillAmount = tiLe;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
