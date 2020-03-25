using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

//クエストの管理
public class QuestM : MonoBehaviour
{

    public StageUIMa StageUI;
    public GameObject enemyPrefab;
    public BattleMG BattleMG;
    public SceneTransitionManager sceneTransitionManager;
    public GameObject questBG;

    int[] encountTable = { -1, -1, 0, -1, 0, -1 };

    int currentStage = 0; 
    private void Start()
    {
        StageUI.UpdateUI(currentStage);
        DialogTextManager.instance.SetScenarios(new string[] { "洞窟に到着" });
    }

    IEnumerator Seaching()
    {
        DialogTextManager.instance.SetScenarios(new string[] { "探検中" });
        questBG.transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 2f)
            .OnComplete(() => questBG.transform.localScale = new Vector3(1, 1, 1));

        SpriteRenderer questBGSpriteRenderer = questBG.GetComponent<SpriteRenderer>();
        questBGSpriteRenderer.DOFade(0, 2f)
            .OnComplete(() => questBGSpriteRenderer.DOFade(1, 0));

        yield return new WaitForSeconds(2f);

        currentStage++;

        StageUI.UpdateUI(currentStage);


        if (encountTable.Length <= currentStage)
        {
            QuestClear();
        }
        else if (encountTable[currentStage] == 0)
        {
            EncountEnemy();
        }
        else
        {
            StageUI.ShowButtons();
        }
    }

    public void OnNextButton()
    {
        SoundMG.instance.PlaySE(0);
        StageUI.HideButtons();
        StartCoroutine(Seaching());
    }

    public void OnToTownButton()
    {
        SoundMG.instance.PlaySE(0);
    }

    void EncountEnemy()
    {
        DialogTextManager.instance.SetScenarios(new string[] { "Enemy出現！！" });
        StageUI.HideButtons();
        GameObject enemyobj = Instantiate(enemyPrefab);
        enemyMG enemy = enemyobj.GetComponent<enemyMG>();
        BattleMG.Setup(enemy);

    }

    public void EndBattle()
    {
        StageUI.ShowButtons();
        DialogTextManager.instance.SetScenarios(new string[] { "Enemyを倒した！！" });
    }

    void QuestClear()
    {
        DialogTextManager.instance.SetScenarios(new string[] { "お宝GET！！ \n街にもどろ〜！！" });
        SoundMG.instance.stopBGM();
        SoundMG.instance.PlaySE(2);
        StageUI.ShowClearText();
    }
}
