using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveResult : MonoBehaviour
{
    private GameDirector _gameDirector;
    public void Save()
    {
        _gameDirector = GameObject.FindWithTag("GameController").GetComponent<GameDirector>();
        PlayerPrefs.SetInt("Score", _gameDirector.Score);
        Debug.Log(PlayerPrefs.GetInt("Score"));
    }
   
}
