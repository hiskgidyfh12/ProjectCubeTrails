using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class vrag : MonoBehaviour
{
    public Transform Target;
    public float sp = 4.99f;
    void Start()
    {
        
    }

    void Update()
    {
        
        var Vec = Target.position - transform.position;
        var Dict = Vec.normalized;

        transform.position += Dict * sp *Time.deltaTime;   
    }
}
