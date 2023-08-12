using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private bool _isStop;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        _isStop = true;
    }

    // Update is called once per frame
    void Update()
    {
        //controller
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_isStop)
            {
                _isStop = false;
                _player.GetComponent<Player>().PushStart();
            }
            else
            {
                _player.GetComponent<Player>().PushStop();
            }
        }
    }
}
