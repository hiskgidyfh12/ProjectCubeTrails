using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Vector3 point;

    private void OnTriggerEnter(Collider collision)
    {
        collision.transform.position = point;
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, point);
    }

#endif
}
