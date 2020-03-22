using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クエストの管理
public class QuestM : MonoBehaviour
{
        int currentStage = 0;  //現在のステージ進行度を取得


    // Nextbutton押されたら起動
    public void OnNextButton()
    {
       currentStage++;　//進行度を増加
       Debug.Log("進行度増加"+currentStage);
    }
}
