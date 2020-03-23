using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 敵の行動管理（クリック/ステータス）
public class enemyMG : MonoBehaviour
{
    public int hp;
    public int at;
    public new string name;

    // 攻撃とダメージ
    public void Attack(playerMG player)
    {

    }
    public void Damage(int damage)
    {
        hp -= damage;
    }


    public void Ontap()
    {
        Debug.Log("click");
    }

}
