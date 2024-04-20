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
    public GameObject enemyPrefeb;
    public float generatorTimer = 1.75f;

    void Start()
    {

    }

    void Update()
    {

    }

    void CreateEnemy()
    {
        Instantiate(enemyPrefeb, transform.position, Quaternion.identity);
    }

    public void StartGenerator()
    {
        InvokeRepeating("CreateEnemy", 0f, generatorTimer);
    }

    public void CancelGenerator(bool clean = false)
    {
        CancelInvoke("CreateEnemy");
        if (clean)
        {
            Object[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in allEnemies)
            {
                Destroy(enemy);
            }
        }
    }
}