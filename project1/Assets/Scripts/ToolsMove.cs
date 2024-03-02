using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ToolsMove : MonoBehaviour
{
    [SerializeField]
    private bool IsBlocked = false;
    [SerializeField]
    private Vector3 _target;
    public bool End { get; set; }

    public bool Chekwall(Vector3 direction)
    {
        if(Physics.Raycast(transform.position, direction, 1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool SetTarget(Vector3 direction, bool force = false)
    {
        Debug.Log(Chekwall(direction));
        if(Chekwall(direction))
        {
            return false;
        }

        if (!IsBlocked || force)
        {
            IsBlocked = true;
            if (!force)
            {
                _target = transform.position + direction;
            }
            else
            {
                _target = direction;
            }

            _target = new Vector3(Mathf.RoundToInt(_target.x), Mathf.RoundToInt((int)_target.y), Mathf.RoundToInt((int)_target.z));
        }

        return true;
    }
    public bool Move()
    {
        if (IsBlocked)
        {
            var Vec = _target - transform.position;
            var norma = Vec.normalized;

            transform.position += norma * Time.deltaTime * 2;

            if(Vec.magnitude <= 0.0125f) 
            {
                transform.position = new Vector3(_target.x, transform.position.y, _target.z);
                IsBlocked = false;
                End = true;
            }
            return false;

        }
        return true;
    }
    
}
