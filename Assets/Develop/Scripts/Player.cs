using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private GameObject[] _children;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _children = GameObject.FindGameObjectsWithTag("playerchildren");
        _rigidbody.isKinematic = true;
    }

    public void SetGravity(float stage)
    {
        _rigidbody.gravityScale = stage;
        foreach (GameObject child in _children)
        {
            child.GetComponent<Rigidbody2D>().gravityScale = stage;
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
        _rigidbody.isKinematic = true;
    }
}
