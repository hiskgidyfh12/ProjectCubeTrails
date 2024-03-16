using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private ToolsMove _tools;
    [SerializeField]
    private GameController _gameController;
    public bool moving;


    // Start is called before the first frame update
    void Start()
    {
        _tools = GetComponent<ToolsMove>();
        _gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_gameController.TurnPlayer) return;


        //
        if(Input.GetKeyDown(KeyCode.W)) 
        {
            _tools.SetTarget(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _tools.SetTarget(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _tools.SetTarget(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _tools.SetTarget(Vector3.back);
        }
        _tools.Move();
        //

        if (_tools.End)
        {
            _tools.End = false;
            _gameController.EndOfTurnPlayer();
        }
    }
}
