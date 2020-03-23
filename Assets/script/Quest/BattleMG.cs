using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 対戦管理
public class BattleMG : MonoBehaviour
{
    public QuestM questM;
    public PlaryerUIMG playerUI;
    public EnemyUIMG enemyUI;
    public playerMG player;
    enemyMG enemy;

    private void Start()
    {
        enemyUI.gameObject.SetActive(false);
    }

    // 初期設定
    public void Setup(enemyMG enemyMG)
    {
        enemyUI.gameObject.SetActive(true);
    enemy = enemyMG;
        enemyUI.SetupUI(enemy);
        playerUI.SetupUI(player);
        enemy.AddEventListenerOnTap(playerAttack);
    }
    void playerAttack()
    {
        player.Attack(enemy);
        enemyUI.UpdateUI(enemy);
        if (enemy.hp <= 0)
        {
            Destroy(enemy.gameObject);
            EndBattle();
            enemyUI.gameObject.SetActive(false);
        }
        else
        {
            enemyTurn();
        }

    }

    void enemyTurn()
    {
        enemy.Attack(player);
        playerUI.UpdateUI(player);
    }

    void EndBattle()
    {
        questM.EndBattle();

    }
}
