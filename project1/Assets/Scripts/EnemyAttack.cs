using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            if(PlayerPrefs.HasKey("Hearts"))
            {

            }
            Debug.Log("Вы атакованы");
            SceneManager.LoadScene("Game");
        }
    }
}
