using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private GameObject _player;
    private GameObject _floor;
    private GameObject _camera;
    [SerializeField] private bool _isStop = false;
    [SerializeField] private bool _isMouse = false;
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
        //Ray
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (!hit || hit.transform.gameObject.tag != "UI")
            {
                StartStop();
            }
        }

        //controller
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || _isMouse)
        {
            StartStop();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PushReset();
        }
    }

    void StartStop()
    {
        if (_isStop)
            {
                PushStart();
            }
            else
            {
                PushStop();
            }
    }

    public void PushStart()
    {
        _isStop = false;
        _floor.GetComponent<Floor>().PushStart();
        _player.GetComponent<Player>().PushStart();
    }

    public void PushReset()
    {
        _isStop = true;
        _floor.GetComponent<Floor>().PushReset();
        _player.GetComponent<Player>().PushReset();
        _camera.GetComponent<CameraMove>().PushReset();
    }

    public void PushStop()
    {
        _isStop = true;
        _player.GetComponent<Player>().PushStop();
    }
}
