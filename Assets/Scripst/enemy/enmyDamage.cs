using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enmyDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 10;
    float damageRate = 5f;
    public float pustBackForce;
    float nextDamege;
    public AudioSource aus;
    public AudioClip attackSound;
    void Start()
    {
        nextDamege = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NguoiChoi") && nextDamege < Time.time)
        {
            TrangThaiNV nV = collision.gameObject.GetComponent<TrangThaiNV>();
            nV.addDamage(damage);
            nextDamege = damageRate + Time.time;
            Debug.Log("dacham");
            pusBack(collision.transform);
            if (aus && attackSound != null)
            {
                aus.PlayOneShot(attackSound);
            }
        }
    }

    

    void pusBack(Transform pustPlayer)
    {
        Vector2 pustDrirection = new Vector2((pustPlayer.position.x - transform.position.x), 0).normalized;
        pustDrirection *= pustBackForce;
        Rigidbody2D pustRB =  pustPlayer.gameObject.GetComponent<Rigidbody2D>();
        pustRB.velocity = Vector2.zero;
        pustRB.AddForce(pustDrirection, ForceMode2D.Impulse);
    }
}
