using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using System.Linq;
using UnityEngine.UI;

public class display : MonoBehaviour
{
    public Text targetText;

    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        string tempScore = "";

        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("data");

        query.OrderByAscending ("score");

        query.Limit = 3;

        query.FindAsync ((List<NCMBObject> objList ,NCMBException e) => {
            if (e != null) {
                UnityEngine.Debug.Log ("ランキング取得失敗");
            } else {
                //検索成功時の処理
                UnityEngine.Debug.Log ("ランキング取得成功");
                // 値とインデックスのペアをループ処理
                foreach (NCMBObject obj in objList)
                    {
                        count++;
                        //★ユーザーネームとスコアを画面表示
                        //tempScore += count.ToString() + "位：" + obj ["UserName"] + " スコア：" + obj ["score"] + "\r\n";
                        tempScore += count.ToString() + " スコア：" + obj ["score"] + "\r\n";
                    }
                    targetText.GetComponent<Text>().text = tempScore;
                }                     
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
