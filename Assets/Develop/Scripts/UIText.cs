using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private Text _measureText;
    [SerializeField] private Text _tagetText;
    private int _distance;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _distance = (int)-_player.transform.position.y;
        if (_distance < 300)
        {
            _measureText.text = _distance.ToString() + "m";
        }
        else
        {
            _measureText.text = "?m";
        }
        
    }

    public void SetTagetText(int taget)
    {
        _tagetText.text = taget.ToString() + "mで止めろ！";
    }
}
