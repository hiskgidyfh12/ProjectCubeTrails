using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calor : MonoBehaviour
{

    [SerializeField]
    private MeshRenderer _calor;

    // Start is called before the first frame update
    void Start()
    {
        _calor.material.color = new Color( 0.5f, 0, 0);
    }
}