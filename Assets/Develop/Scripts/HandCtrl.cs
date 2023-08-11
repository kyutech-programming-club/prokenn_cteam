using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCtrl : MonoBehaviour
{

    private HandSprite handSprite;
    private HingeJoint2D hingeJoint;

    // Start is called before the first frame update
    void Start()
    {
        handSprite = this.gameObject.GetComponent<HandSprite>();
        hingeJoint = this.gameObject.GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            handSprite.OpenHand();
            hingeJoint.enabled = false;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            handSprite.CloseHand();
        }
    }
}
