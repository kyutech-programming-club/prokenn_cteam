using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeasureText : MonoBehaviour
{
    private GameObject _player;
    private Text _text;
    private int _distance;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _distance = (int)-_player.transform.position.y;
        _text.text = _distance.ToString() + "m";
    }
}
