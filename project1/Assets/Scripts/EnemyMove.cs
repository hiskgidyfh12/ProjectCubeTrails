using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ToolsMove))]
public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private ToolsMove _tools;
    private PlayerMove _playerMove;
    // Start is called before the first frame update
    void Start()
    {
        _tools = GetComponent<ToolsMove>();
        _playerMove = FindObjectOfType<PlayerMove>();
    }
    public void SetTarget()
    {
        var direction = _playerMove.transform.position - transform.position;

        var x = direction.x;
        var z = direction.z;

        if(Mathf.Abs(x) > Mathf.Abs(z))
        {
            var znak = x > 0 ? 1 : -1;

            _tools.SetTarget(new Vector3(znak, 0, 0));
        }
        else if(Mathf.Abs(x) < Mathf.Abs(z))
        {
            var znak = z > 0 ? 1 : -1;

            _tools.SetTarget(new Vector3(0, 0, znak));
        }
        else
        {
            var znak = x > 0 ? 1 : -1;

            _tools.SetTarget(new Vector3(0, 0, znak));
        }
    }

    // Update is called once per frame
    void Update()
    {
        _tools.Move();
    }
}
