using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calor : MonoBehaviour
{

    [SerializeField]
    private MeshRenderer _calor;

    [SerializeField] private bool _diffcolor;

    // Start is called before the first frame update
    void Start()
    {
        _calor = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (_diffcolor)
        {
            var green = Mathf.Sign(Time.time);
            var red = Mathf.Sin(Time.time);
            var blue = Mathf.Cos(Time.time);
            _calor.material.color = new Color(red, green, blue);
        }
        else
        {
            
        }
    }
}



