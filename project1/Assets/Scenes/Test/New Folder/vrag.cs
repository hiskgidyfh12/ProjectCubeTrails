using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour
{
    public Transform Target;
    public float sp = 1f;
    void Start()
    {
        Target = FindObjectOfType<player>().transform;
    }

    void Update()
    {
        var Vec = Target.position - transform.position;
        var Dict = Vec.normalized;

        transform.position += Dict * Time.deltaTime*sp;   
    }
}
