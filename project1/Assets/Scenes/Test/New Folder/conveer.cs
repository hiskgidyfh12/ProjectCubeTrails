using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class conveer : MonoBehaviour
{
    public float Speed = 3f;
    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            transform.position += Vector3.back * Speed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
