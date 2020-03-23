using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 対戦管理
public class BattleMG : MonoBehaviour
{
    public playerMG player;
    public enemyMG enemy;
    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }
}
