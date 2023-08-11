using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    private Transform _transform;
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    public void PushStart()
    {
        _transform.position = new Vector3(10, _transform.position.y, _transform.position.z);
    }

    public void PushReset()
    {
        _transform.position = new Vector3(0, _transform.position.y, _transform.position.z);
    }
}
