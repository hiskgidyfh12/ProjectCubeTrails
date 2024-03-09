using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public string next;

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(next);
    }
}
