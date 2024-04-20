using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    float rotateSpeed = 0.002f;

    Vector2 p1;
    Vector2 p2;

    void Update()
    {
        CameraRotation();
    }


    void CameraRotation()
    {
        if (Input.GetMouseButtonDown(1))
        {
            p1 = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            p2 = Input.mousePosition;

            float dx = (p2 - p1).x * rotateSpeed;
            float dy = (p2 - p1).y * rotateSpeed;

            transform.rotation *= Quaternion.Euler(new Vector3(0, dx, 0));
        }
    }
}