using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameDirector : MonoBehaviour
{
    private Player _player;
    private Transform _playerTransform;
    [SerializeField] private UIText _uiText;
    [SerializeField] private PopupText _popupText;
    public int TagetMeasure { get; private set; }
    private int _stageSelect;
    private float[] _stages;
    public int Distance { get; private set; }
    public int Score { get; private set; }

    void Awake()
    {
        //好きに設定する
        _stages = new float[] {9.8f, 1.62f};
        TagetMeasure = Random.Range(300, 2000);

        _stageSelect = Random.Range(0, _stages.Length);
    }
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<Player>();

        DOVirtual.DelayedCall(0.1f, () =>
        {
            _player.SetGravity(_stages[_stageSelect]);
            _uiText.SetTagetText(TagetMeasure);
        });

        Debug.Log("目標距離は" + TagetMeasure + "m");
        Debug.Log("重力は" + _stages[_stageSelect] + "G");
    }

    public void GameStop()
    {
        _playerTransform = GameObject.FindWithTag("Player").transform;
        Distance = (int)-_playerTransform.position.y;
        Score = Mathf.Abs(Distance - TagetMeasure);
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
