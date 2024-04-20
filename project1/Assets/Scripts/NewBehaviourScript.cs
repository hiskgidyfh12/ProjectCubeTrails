using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEditor.PackageManager;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.XR;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject thing;

    public Vector3 target;
    public int fish = 3;

    private int enemy => FindObjectsOfType<vrag>().Length;




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (enemy < fish)
            {
                GameObject copiedThing = Instantiate(thing, target, Quaternion.identity);
            }
        }



        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}