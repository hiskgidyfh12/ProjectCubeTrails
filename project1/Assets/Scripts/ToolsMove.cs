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
    public bool End;

    public bool Chekwall(Vector3 direction)
    {
        if (Physics.Raycast(transform.position, direction, out RaycastHit hitinfo, 1))
        {
            return hitinfo.collider.tag == "Wall";
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
            End = true;
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

    public Vector3 OldCoords;
    public Vector3 Delta;

    public bool Move()
    {
        if (IsBlocked)
        {
            var Vec = _target - transform.position;
            var norma = Vec.normalized;
            OldCoords = transform.position;

            transform.position += norma * Time.deltaTime * 2;
            Delta = transform.position - OldCoords;
            if ((transform.position - OldCoords).magnitude  < 0.0005f)
            {
                IsBlocked = false;
                End = true;
            }
            if (Vec.magnitude <= 0.0125f)
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
