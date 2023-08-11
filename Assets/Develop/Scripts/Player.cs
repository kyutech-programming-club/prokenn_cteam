using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Dropdown _stageSelect;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _stageSelect = GameObject.Find("StageDropdown").GetComponent<Dropdown>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {
        //重力加速度の変更
        if(_stageSelect.value == 0)
        {
            _rigidbody.gravityScale = 9.8f;
        }
        else if(_stageSelect.value == 1)
        {
            _rigidbody.gravityScale = 1.62f;
        }

    }

    public void PushStart()
    {
        _rigidbody.isKinematic = false;
    }
    
    public void PushStop()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.angularVelocity = 0;
        _rigidbody.isKinematic = true;
    }

    public void PushReset()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.angularVelocity = 0;
        transform.position = new Vector3(0, 0, 100);
        _rigidbody.isKinematic = false;
    }
}
