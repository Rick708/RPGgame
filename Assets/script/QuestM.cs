using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クエストの管理
public class QuestM : MonoBehaviour
{
    public StageUIMa StageUI;
    public GameObject enemyPrefab;
    public BattleMG BattleMG;
    // 敵に遭遇確率 0=遭遇
    int[] encountTable = { -1, -1, 0, -1, 0, -1 };

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
       if(encountTable.Length <= currentStage)
        {
            Debug.Log("Happy");
        }
       else if (encountTable[currentStage] == 0)
        {
            EncountEnemy();

        }
    }
    void EncountEnemy()
    {
        StageUI.HideButtons();
        GameObject enemyobj = Instantiate(enemyPrefab);
        enemyMG enemy = enemyobj.GetComponent<enemyMG>();
        BattleMG.Setup(enemy);

    }
}
