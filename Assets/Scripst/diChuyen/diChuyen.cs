using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diChuyen : MonoBehaviour
{
    public Animator amin;
    public float speed = 5f;
    public AudioSource aus;
    public AudioClip jumSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal") * speed;
        float y = Input.GetAxisRaw("Vertical") * speed;
        transform.position += new Vector3(x, y, 0) * Time.deltaTime;

       
        
            if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            amin.Play("runRigth");
        }

            if (Input.GetKeyUp(KeyCode.RightArrow))
                amin.Play("idleRigth");

            if (Input.GetKeyDown(KeyCode.LeftArrow))
                amin.Play("runLeft");

            if (Input.GetKeyUp(KeyCode.LeftArrow))
                amin.Play("idleLeft");


            if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (aus && jumSound != null)
            {
                aus.PlayOneShot(jumSound);
            }
            amin.Play("jump");
        }
              

      
        }
    }

