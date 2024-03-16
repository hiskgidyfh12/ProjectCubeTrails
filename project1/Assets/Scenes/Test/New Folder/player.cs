using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class player : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right*Speed, ForceMode.Impulse);


        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left*Speed, ForceMode.Impulse);


        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * Speed, ForceMode.Impulse);


        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * Speed, ForceMode.Impulse);


        }

    }    }    

