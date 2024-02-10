using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private EnemyMove[] _enemyMove;
    [SerializeField]
    private PlayerMove _playerMove;
    public bool TurnPlayer = true;
    // Start is called before the first frame update
    void Start()
    {
        _playerMove = FindObjectOfType<PlayerMove>();
        _enemyMove = FindObjectsOfType<EnemyMove>();

    }
    public void EndOfTurnEnemy()
    {
        TurnPlayer = true; 
    }
    public void EndOfTurnPlayer()
    {
        if (TurnPlayer)
        {
            TurnPlayer = false;
            foreach(var enemy in _enemyMove)
            {
                enemy.SetTarget();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
