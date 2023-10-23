using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public TrangThaiNV playerState;
    public float maxhealth = 20;
    float currentHealth;
    public GameObject enemyHealthEF;
    public AudioSource aus;
    public AudioClip hurtSound;
    void Start()
    {
        currentHealth = maxhealth;
        playerState = GameObject.Find("nguoiChoi").GetComponent<TrangThaiNV>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamge(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            if (aus && hurtSound != null)
            {
                aus.PlayOneShot(hurtSound);
            }
            makeDead();
        }
    }

 public void makeDead()
    {
        playerState.AddScore(10);
        Instantiate(enemyHealthEF, transform.position, transform.rotation);
        Destroy(gameObject);
       
    }
}
