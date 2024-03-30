using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class died : MonoBehaviour
{
    
    [SerializeField]
    private Text text; 
    private int counter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            counter += 1;

            text.text = counter.ToString();

            Debug.Log("Name of the object: " + other.gameObject.name + counter);
        }
    }
    void Update()
    {
    }
}
