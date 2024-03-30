using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class conveer : MonoBehaviour
{
    public float Speed = 3f;
    public Vector3 dir;
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject)
        {
            other.transform.position += dir * Speed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + dir * Speed);

        Gizmos.DrawCube(transform.position + dir * Speed, Vector3.one / 5);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + dir.normalized * 5);
    }

#endif
}
