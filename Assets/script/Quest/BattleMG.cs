﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

// 対戦管理
public class BattleMG : MonoBehaviour
{
    public Transform cameraobj;
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
        SoundMG.instance.PlayBGM("Battle");
        enemyUI.gameObject.SetActive(true);
        enemy = enemyMG;
        enemyUI.SetupUI(enemy);
        playerUI.SetupUI(player);
        enemy.AddEventListenerOnTap(playerAttack);

    }
    void playerAttack()
    {
        StopAllCoroutines();
        SoundMG.instance.PlaySE(1);
        int damage = player.Attack(enemy);
        DialogTextManager.instance.SetScenarios(new string[] { "Playerの攻撃\nEnemyに" + damage + "のダメージを与えた！！" });
        enemyUI.UpdateUI(enemy);

        if (enemy.hp <= 0)
        {
            StartCoroutine(EndBattle());
        }
        else
        {
            StartCoroutine(enemyTurn());
        }

    }

    IEnumerator enemyTurn()
    {
        
        yield return new WaitForSeconds(2f);
        SoundMG.instance.PlaySE(1);
        cameraobj.DOShakePosition(0.5f, 0.5f, 40, 0, false, true);
        int damage = enemy.Attack(player);
        DialogTextManager.instance.SetScenarios(new string[] { "Enemyの攻撃\nPlayerに" + damage + "のダメージを与えた！！" });
        playerUI.UpdateUI(player);
    }

    IEnumerator EndBattle()
    {
        yield return new WaitForSeconds(2f);

        Destroy(enemy.gameObject);
        SoundMG.instance.PlayBGM("Quest");
        questM.EndBattle();
        enemyUI.gameObject.SetActive(false);
    }
}
