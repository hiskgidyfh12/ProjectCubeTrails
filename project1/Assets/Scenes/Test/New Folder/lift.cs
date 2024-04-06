using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class lift : MonoBehaviour
{
    public bool canMove = true;

    [SerializeField] float speed;
    public int startPoint;
    public Transform[] points;

    private int i;

    public bool reverse;
    public float timer = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, points[i].position) < 0.01f)
        {
            canMove = true;

            if (i == points.Length - 1)
            {
                canMove = false;
                reverse = true;
                timer = 10;
                i--;
                return;

            }
            else if(i == 0)
            {
                canMove = false;
                reverse = false;
                timer = 10;
                i++;
                return;
            }

            if (reverse)
            {
                i--;
            }
            else
            {
                i++;
            }



        }
        if(canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed*Time.deltaTime);
        }
        else
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else 
            {
                canMove = true;
            }


        }

    }
}
