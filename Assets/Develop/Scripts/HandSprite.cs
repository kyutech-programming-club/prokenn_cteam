using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSprite : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject TargetObject;
    private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite OpenSprite;
    [SerializeField] private Sprite CloseSprite;
    void Start()
    {
        TargetObject = this.gameObject;
        spriteRenderer = TargetObject.GetComponent<SpriteRenderer>();
    }

    private void CheckExistance(){
        if (TargetObject == null)
        {
            return;
        }
        if (OpenSprite == null || CloseSprite == null)
        {
            return;
        }
        if (spriteRenderer == null)
        {
            return;
        }
    }

    public void OpenHand()
    {
        CheckExistance();
        spriteRenderer.sprite = OpenSprite;
    }

    public void CloseHand()
    {
        CheckExistance();
        spriteRenderer.sprite = CloseSprite;
    }
}
