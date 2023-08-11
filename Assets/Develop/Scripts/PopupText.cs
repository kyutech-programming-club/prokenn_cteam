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
    private float _transformy;

    // Start is called before the first frame update
    void Start()
    {
        _gameDirector = GameObject.FindWithTag("GameController").GetComponent<GameDirector>();
        _transformy = transform.position.y;
        transform.position = new Vector3(transform.position.x, _transformy + 1000, transform.position.z);
        DOVirtual.DelayedCall(0.1f, () =>
        {
            _text.text = _gameDirector.TagetMeasure.ToString() + "mで止めろ！";
            transform.DOMoveY(_transformy, _speed);
        });

        DOVirtual.DelayedCall(4.0f, () =>
        {
            transform.DOMoveY(_transformy + 1000, _speed);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
