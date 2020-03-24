using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//音源とスピーカー用意
public class SoundMG : MonoBehaviour
{
    // シングルトン
    // ゲーム内に１つしか存在しない物（音を管理する物とか）
    // 利用場所：シーン間でのデータ共有/オブジェクト共有
    // 書き方
    public static SoundMG instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public AudioSource audioSourceBGM; // BGMのスピーカー
    public AudioClip[] audioClipsBGM;  // BGMの素材（0:Title, 1:Town, 2:Quest, 3:Battle）
    public AudioSource audioSourceSE; // SEのスピーカー
    public AudioClip[] audioClipsSE; // ならす素材

    public void stopBGM()
    {
        audioSourceBGM.Stop();
    }

    private void Start()
    {
        PlayBGM("title");
    }


    public void PlayBGM(string sceneName)
    {
        audioSourceBGM.Stop();
        switch (sceneName)
        {
            default:
            case "Title":
                audioSourceBGM.clip = audioClipsBGM[0];
                break;
            case "Town":
                audioSourceBGM.clip = audioClipsBGM[1];
                break;
            case "Quest":
                audioSourceBGM.clip = audioClipsBGM[2];
                break;
            case "Battle":
                audioSourceBGM.clip = audioClipsBGM[3];
                break;
        }
        audioSourceBGM.Play();
    }


    public void PlaySE(int index)
    {
        audioSourceSE.PlayOneShot(audioClipsSE[index]); // SEを一度だけならす
    }
}
