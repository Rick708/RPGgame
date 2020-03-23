using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMG : MonoBehaviour
{
    public int hp;
    public int at;

    // 攻撃とダメージ
    public void Attack(enemyMG enemy)
    {
        enemy.Damage(at);
    }
    public void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
        }
    }
}
