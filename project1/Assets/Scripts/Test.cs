using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public string Name;
    public Color Color;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKey(KeyCode.H))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
      
    }
}
