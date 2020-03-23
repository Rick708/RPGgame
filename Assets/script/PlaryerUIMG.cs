using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaryerUIMG : MonoBehaviour
{
    public Text hpText;
    public Text atText;

    public void UpdateUI(int currentStage)
    {
        hpText.text = string.Format("ステージ：{0}", 80);
    }

}
