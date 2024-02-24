using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public EnemyAttack enemyAttack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Heart1.SetActive(enemyAttack.Validate(1));
        Heart2.SetActive(enemyAttack.Validate(2));
        Heart3.SetActive(enemyAttack.Validate(3));

    }
}
