using System;
using UnityEngine;
using DG.Tweening;

// 敵の行動管理（クリック/ステータス）
public class enemyMG : MonoBehaviour
{
    public int hp;
    public int at;
    public new string name;
    public GameObject hitEffect;

    Action tapAction;


    public int Attack(playerMG player)
    {
        int damage = player.Damage(at);
        return damage;
    }
    public int Damage(int damage)
    {
        Instantiate(hitEffect);
        transform.DOShakePosition(0.5f, 0.5f, 40, 0, false, true);
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
        }
        return damage;
    }

    public void AddEventListenerOnTap(Action action)
    {
        tapAction += action;
    }

    public void Ontap()
    {
        tapAction();
    }

}
