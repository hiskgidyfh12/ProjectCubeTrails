using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    public int Hearts;

    // Start is called before the first frame update
    void Start()
    {
        Hearts = PlayerPrefs.GetInt("Hearts", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool Validate(int hearts)
    {
        return hearts <= Hearts;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Hearts = PlayerPrefs.GetInt("Hearts", 3);
            Hearts = Hearts - 1;
            PlayerPrefs.SetInt("Hearts", Hearts);

            Debug.Log($"Вы атакованы {Hearts}");

            if (Hearts <= 0)
            {
                PlayerPrefs.SetInt("Hearts", 3);
                SceneManager.LoadScene("StartMenu");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
