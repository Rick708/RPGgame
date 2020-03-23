using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyUIMG : MonoBehaviour
{
    public Text hpText;
    public Text nameText;

    public void UpdateUI(int currentStage)
    {
        hpText.text = string.Format("ステージ：{0}", 80);
    }

}
