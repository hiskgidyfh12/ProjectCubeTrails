using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var mv =  other.GetComponent<ToolsMove>();
        mv.SetTarget(newPosition, true);
        other.transform.position = _target.transform.position;
    }
}
