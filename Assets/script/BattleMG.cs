using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 対戦管理
public class BattleMG : MonoBehaviour
{
    public PlaryerUIMG playerUI;
    public EnemyUIMG enemyUI;
    public playerMG player;
    enemyMG enemy;

    // 初期設定
    public void Setup(enemyMG enemyMG)
    {
        enemy = enemyMG;
        enemyUI.SetupUI(enemy);
        playerUI.SetupUI(player);
    }
    void playerAttack()
    {
        player.Attack(enemy);
        enemyUI.UpdateUI(enemy);
    }
    void enemyAttack()
    {
        enemy.Attack(player);
        playerUI.UpdateUI(player);
    }
}
