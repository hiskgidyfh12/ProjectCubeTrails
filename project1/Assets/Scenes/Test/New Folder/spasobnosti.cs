using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spasobnosti : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 0.01f;
    // Start is called before the first frame update

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            

        }
    }
}
