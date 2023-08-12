using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using NCMB;

public class lanking : MonoBehaviour
{

    public string currentUserName;
    public bool key;
    [SerializeField]
    int score = 100;
    NCMBObject data = new NCMBObject("data");

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        key = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return) && !key){
            key = true;
            Debug.Log("スペースキーが押されました。");

        // NCMBUser currentUser = NCMBUser.CurrentUser;

        // if(currentUser != null) {
        //     UnityEngine.Debug.Log("ログイン中のユーザー：" + currentUser.UserName);
        // } else {
        //     UnityEngine.Debug.Log ("未ログインまたは取得に失敗");
        // }

            data["score"] = score;
            data["UserName"] = currentUserName;
            data.SaveAsync();

            return;
        }
    }
}
