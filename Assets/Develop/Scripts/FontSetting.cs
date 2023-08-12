using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FontSetting : MonoBehaviour
{
    [SerializeField] private Font _font;
    [SerializeField] private List<GameObject> _textObjects;
    [SerializeField] private Color _color;

    private void Awake()
    {
        foreach (GameObject textObject in _textObjects)
        {
            textObject.GetComponent<UnityEngine.UI.Text>().font = _font;
            textObject.GetComponent<UnityEngine.UI.Text>().color = _color;
        }
    }
}
