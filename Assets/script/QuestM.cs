using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クエストの管理
public class QuestM : MonoBehaviour
{
    public StageUIMa StageUI;

    int currentStage = 0; // 現在のステージ進行度
    private void Start()//Startが小文字だと反応しない
    {
        StageUI.UpdateUI(currentStage);// 名前の大文字小文字は合わせる
    }

    // Nextbutton押されたら起動
    public void OnNextButton()
    {
       currentStage++;　
       StageUI.UpdateUI(currentStage);
    }
}
