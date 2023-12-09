using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public GameObject cube;
    public bool moving;
    private Vector3 _target;

    private Vector3 _oldCoords;

    //public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        cube = gameObject;
        _oldCoords = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!moving)
        {
            if (Input.GetKeyDown(KeyCode.W)) //&& canMove==true
            {
                //cube.transform.position += new Vector3(0, 0, 1);
                _target = transform.position + new Vector3(0, 0, 1);
                moving = true;
            }
            if (Input.GetKeyDown(KeyCode.S)) //&& canMove == true
            {
                //cube.transform.position += new Vector3(0, 0, -1);
                _target = transform.position + new Vector3(0, 0, -1);
                moving = true;
            }
            if (Input.GetKeyDown(KeyCode.A)) //&& canMove==true  
            {
                //cube.transform.position += new Vector3(-1, 0, 0);
                _target = transform.position + new Vector3(-1, 0, 0);
                moving = true;
            }
            if (Input.GetKeyDown(KeyCode.D)) //&& canMove==true  
            {
                //cube.transform.position += new Vector3(1, 0, 0);
                _target = transform.position + new Vector3(1, 0, 0);
                moving = true;
            }
        }
        else
        {
            var dir = _target - transform.position;
            if (dir.magnitude > 0.1)
            {
                transform.position += dir.normalized * Time.deltaTime;
            }
            else
            {
                transform.position = _target;
                moving = false;
            }
        }
    }
}
