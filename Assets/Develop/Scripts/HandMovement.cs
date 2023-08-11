using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private float power = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody2D.velocity = power * transform.right * Mathf.Cos(Time.time);
    }
}
