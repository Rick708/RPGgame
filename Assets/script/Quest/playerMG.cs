using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMG : MonoBehaviour
{
    public int hp;
    public int at;

    // 攻撃とダメージ
    public int Attack(enemyMG enemy)
    {
        int damage = enemy.Damage(at);
        return damage;
    }
    public int Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
        }
        return damage;
    }
}
