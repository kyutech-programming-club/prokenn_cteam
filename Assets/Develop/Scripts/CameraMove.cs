﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(_player.transform.position.y < -0.5f)
        {
            transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y +0.5f, transform.position.z);
        }
    }

    public void PushReset()
    {
        transform.position = new Vector3(0, 0, transform.position.z);
    }
}
