using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PopupText : MonoBehaviour
{
    [SerializeField] float _speed = 0.5f;
    private GameDirector _gameDirector;
    [SerializeField] private Text _text;
    private float _transformY;

    void Awake()
    {
        _gameDirector = GameObject.FindWithTag("GameController").GetComponent<GameDirector>();
        _transformY = transform.position.y;
        transform.position = new Vector3(transform.position.x, _transformY + 1000, transform.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {   
        _text.text = _gameDirector.TagetMeasure.ToString() + "mで止めろ！";
        transform.DOMoveY(_transformY, _speed);
        DOVirtual.DelayedCall(4.0f, () =>
        {
            transform.DOMoveY(_transformY + 1000, _speed);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
