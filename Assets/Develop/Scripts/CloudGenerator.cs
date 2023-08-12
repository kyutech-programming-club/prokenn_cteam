using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
    private Transform transform;
    private Vector3 prevPos;
    [SerializeField] private float generateDistance = 68f;
    [SerializeField] private GameObject cloud_1, cloud_2;
    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.GetComponent<Transform>();
        prevPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(this.transform.position, prevPos);
        if (distance > generateDistance)
        {
            Instantiate(cloud_1, new Vector3(this.transform.position.x + 1.0f, transform.position.y - generateDistance, 500f), Quaternion.identity);
            Instantiate(cloud_2, new Vector3(this.transform.position.x - 1.0f, transform.position.y - generateDistance, 500f), Quaternion.identity);
            prevPos = this.transform.position;
        }
    }
}
