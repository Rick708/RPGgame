using System;
using UnityEngine;
using DG.Tweening;

// 敵の行動管理（クリック/ステータス）
public class enemyMG : MonoBehaviour
{
    public int hp;
    public int at;
    public new string name;

    //関数登録
    Action tapAction; //クリックされた時に実行したい関数を入れるBMGから持ってっ来る


    // 攻撃とダメージ
    public void Attack(playerMG player)
    {
        player.Damage(at);
    }
    public void Damage(int damage)
    {
        transform.DOShakePosition(0.5f, 0.5f, 40, 0, false, true);
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
        }
    }

    // tapActionに関数を登録する関数を作る

    public void AddEventListenerOnTap(Action action)
    {
        tapAction += action;
    }

    public void Ontap()
    {
        Debug.Log("click");
        tapAction();
    }

}
