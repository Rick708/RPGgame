﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public void LoadTo(string sceneName)
    {
        FadeIOMG.instance.FadeOutToIn(() => Load(sceneName));
    }
    void Load(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        SoundMG.instance.PlayBGM(sceneName);
    }

}
