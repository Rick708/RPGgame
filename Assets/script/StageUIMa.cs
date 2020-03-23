using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ステージ情報管理
public class StageUIMa : MonoBehaviour
{
    public Text stageText;

    public void UpdateUI(int currentStage)
    {
        stageText.text = string.Format("ステージ：{0}", currentStage+1);
    }
}
