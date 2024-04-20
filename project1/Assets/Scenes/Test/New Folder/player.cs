using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class player : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 0.01f;
    private bool isJumping;
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
            // rb.AddForce(Vector3.right * Speed, ForceMode.Impulse);
            transform.position += Vector3.right * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;


        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Speed * Time.deltaTime;


        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Speed * Time.deltaTime;


        }
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.velocity = new Vector3(0, 10, 0);
            isJumping = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    
    {
        isJumping = false;
    }

}        

