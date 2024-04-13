using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera : MonoBehaviour
{
    [SerializeField] private Transform target;

    public float rotSpeed = 1.5f; //�������� ��������
    public float zoomSpeed = 5.0f; //�������� ����������� ������
    private float _rotY, _rotX; //���� �� x � y
    private Vector3 _offset; //�������� ������ ������������ �������


    // Use this for initialization
    void Start()
    {
        _rotY = transform.eulerAngles.y;
        _rotX = transform.eulerAngles.x;
        _offset = target.position - transform.position; //�������� ��������� ��������
    }

    void LateUpdate()
    {
        
          float input = Input.GetAxis("Mouse ScrollWheel");
          if (input != 0) //���� �������� �������� ����
          {
            Camera.main.fieldOfView += input * zoomSpeed; //���

            //������ ����� ������ ��������, ��� �� ����� �����
            //_offset.x += 10 * input;
            //_offset.y += 10 * input;
          }
        if (Input.GetMouseButton(1)) //������ ������ ����
        {
            _rotY -= Input.GetAxis("Mouse X") * rotSpeed; //������� ������ ������ �������
            _rotX += Input.GetAxis("Mouse Y") * rotSpeed;
        }
        if (_rotY != 0 || _rotX != 0)
        {
            Quaternion rotation = Quaternion.Euler(_rotX, _rotY, 0); //������ �������� ������
            transform.position = target.position - (rotation * _offset);
            transform.LookAt(target);
        }
    }
}

