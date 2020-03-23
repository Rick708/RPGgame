using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyUIMG : MonoBehaviour
{
    public Text hpText;
    public Text nameText;

    public void SetupUI(enemyMG enemy)
    {
        hpText.text = string.Format("HP:{0}", enemy.hp);
        nameText.text = string.Format("{0}", enemy.name);
    }

    public void UpdateUI(enemyMG enemy)
    {
        hpText.text = string.Format("HP:{0}", enemy.hp);
    }
}
