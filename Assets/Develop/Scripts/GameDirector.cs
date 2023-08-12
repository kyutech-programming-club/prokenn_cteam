using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameDirector : MonoBehaviour
{
    private Player _player;
    [SerializeField] private UIText _uiText;
    [SerializeField] private PopupText _popupText;
    public int TagetMeasure { get; private set; }
    private int _stageSelect;
    private float[] _stages;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<Player>();

        //好きに設定する
        _stages = new float[] {9.8f, 1.62f};
        TagetMeasure = Random.Range(300, 2000);

        _stageSelect = Random.Range(0, _stages.Length);

        DOVirtual.DelayedCall(0.1f, () =>
        {
            _player.SetGravity(_stages[_stageSelect]);
            _uiText.SetTagetText(TagetMeasure);
            _popupText.Start_(TagetMeasure);

        });

        Debug.Log("目標距離は" + TagetMeasure + "m");
        Debug.Log("重力は" + _stages[_stageSelect] + "G");
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
