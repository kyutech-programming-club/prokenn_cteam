using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private GameObject _player;
    private GameDirector _gameDirector;
    private SaveResult _saveResult;
    [SerializeField] private Result _result;
    [SerializeField] private bool _isStop;
    [SerializeField] private bool _isStart;
    // Start is called before the first frame update
    void Start()
    {
        _saveResult = GetComponent<SaveResult>();
        _player = GameObject.FindWithTag("Player");
        _gameDirector = GetComponent<GameDirector>();
        _isStop = false;
        _isStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        //controller
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!_isStart)
            {
                _isStart = true;
                _isStop = false;
                _player.GetComponent<Player>().PushStart();
            }
            else if (!_isStop)
            {
                _isStop = true;
                _player.GetComponent<Player>().PushStop();
                _gameDirector.GameStop();
                _result.GameStop();
                _saveResult.Save();
            }
            else
            {
                SceneManager.LoadScene("lanking");
            }
        }
    }
}
