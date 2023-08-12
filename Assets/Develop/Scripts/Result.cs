using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Result : MonoBehaviour
{
    [SerializeField] float _speed = 0.5f;
    private GameDirector _gameDirector;
    private float _transformY;

    [SerializeField] private Text _tagetText;
    [SerializeField] private Text _resultText;
    [SerializeField] private Text _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        _transformY = transform.position.y;
        transform.position = new Vector3(transform.position.x, _transformY + 1000, transform.position.z);
    }

    public void GameStop()
    {
        _gameDirector = GameObject.FindWithTag("GameController").GetComponent<GameDirector>();
        _tagetText.text = _gameDirector.TagetMeasure.ToString() + "m";
        _resultText.text = _gameDirector.Distance.ToString() + "m";
        _scoreText.text = _gameDirector.Score.ToString() + "m";
        DOVirtual.DelayedCall(2.0f, () =>
        {
            transform.DOMoveY(_transformY, _speed);
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
