using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownMG : MonoBehaviour
{
    private void Start()
    {
        DialogTextManager.instance.SetScenarios(new string[] { "さぁ！！\n冒険へ出かけよう！！" });
    }

    public void OnToQuestButton()
    {
        SoundMG.instance.PlaySE(0);
    }
}
