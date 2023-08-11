using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cpntroller : MonoBehaviour
{
    private GameObject _player;
    private GameObject _floor;
    private GameObject _camera;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
        _floor = GameObject.Find("StartFloor");
        _camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PushStop();
        }
    }

    public void PushStart()
    {
        _floor.GetComponent<Floor>().PushStart();
        _player.GetComponent<Player>().PushStart();
    }

    public void PushReset()
    {
        _floor.GetComponent<Floor>().PushReset();
        _player.GetComponent<Player>().PushReset();
        _camera.GetComponent<CameraMove>().PushReset();
    }

    public void PushStop()
    {
        _player.GetComponent<Player>().PushStop();
    }
}
