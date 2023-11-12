using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComBat : MonoBehaviour
{
 public Animator amin;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemeyLayer;
    public float damage = 10;
    public AudioSource aus;
    public AudioClip attackSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (aus && attackSound != null)
            {
                aus.PlayOneShot(attackSound);
            }
            Attack();
        }
    }

    void Attack()
    {
        amin.SetTrigger("attack");
    Collider2D[] hitEnamies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemeyLayer);
        foreach(Collider2D enemy in hitEnamies)
        {
            Debug.Log("chem");
            enemy.GetComponent<enemyHealth>().addDamge(damage);
 
        }

    }
     void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

