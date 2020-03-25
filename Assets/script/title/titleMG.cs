using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleMG : MonoBehaviour
{
    private void Start()
    {
        DialogTextManager.instance.SetScenarios(new string[] { "このアプリを選んで頂き有り難う御座います。\n簡単なアプリでは御座いますが\n楽しんでください。" });
    }

    public void OnToTownButton()
    {
        SoundMG.instance.PlaySE(0);
    }
}
