using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleControl : MonoBehaviour
{
    public battleInfo player;
    public battleInfo enermy;
    public GameObject successUI;
    public GameObject lostUI;
    public Transform weaponUI;
    void Start()
    {
        touzis = loadPref.getPref("touzi");
        playerTurnStart();
        enermyBeH += aiuhdiua;
    }
    void Update()
    {
        resultCalculate();
    }
    void creatWeapon()
    {
        for(int i= 0;i<weaponBag.weapons.Count;i++)
        {
            GameObject weapon=Instantiate
                (weaponBag.weapons[i]);
            weaponSort.weapons.Add(weapon.
                GetComponent<weaponDeath>());
        }
    }
    void resultCalculate()
    {
        if(enermy.curHP<=0)
        {
            successUI.SetActive(true);
        }
        if(player.curHP<=0)
        {
            lostUI.SetActive(true);
        }
    }
    public void playerTurnStart()
    {
        playerTurn = true;
        creatTouzi(count);
        creatWeapon();
        playerPoisonCalcu();
        StartCoroutine(playerFreezeCalcu());
        playerFreezeCalcu();
    }
    IEnumerator playerFreezeCalcu()
    {
        float t = 0;
        while(t<0.1)
        {
            t += Time.deltaTime;
            yield return null;
        }
        for(int i= 0;i<player.freeze&&i<autoSort.touzis.Count;i++)
        {
            autoSort.touzis[i].count = 1;
        }
        player.freeze = 0;
    }
    void playerPoisonCalcu()
    {
        if(player.poison>0)
        {
            enermyHit(player.poison);
            player.poison--;
        }
    }
    public Action enermyBeH;
    void enermyBehave()
    {
        enermyBeH();
    }
    int a = 0;
    void aiuhdiua()
    {
        a++;
    }
    bool playerTurn = true;
    public void onClickNext()
    {
        if (playerTurn)
        {
            for (int i = 0; i < autoSort.touzis.Count; i++)
            {
                autoSort.touzis[i].beUsed = true;
            }
            for (int i = 0; i < weaponSort.weapons.Count; i++)
            {
                weaponSort.weapons[i].GetComponentInChildren
                    <weaponInfo>().beUsed = true;
            }
            enermyBehave();
            playerTurn = false;
        }
    }
    GameObject touzis;
    public int count;
    void creatTouzi(int count)
    {
        for(int i = 0; i < count; i++)
        {
            GameObject touzi = Instantiate(touzis);
            autoSort.touzis.Add(touzi.
                GetComponent<touziInfo>());
        }
    }
    public void playerHit(int hurt)
    {
        enermy.curHP -= hurt;
    }
    public void playerBeFreeze(int freeze)
    {
        player.freeze += freeze;
    }
    public void playerBePoison(int posion)
    {
        player.poison += posion;
    }
    public playerMPprint playerMP;
    public void enermyHit(int hurt)
    {
        player.curHP -= hurt;
        playerMP.curMP += hurt;
    }
    public void enermyBeFreeze(int freeze)
    {
        enermy.freeze += freeze;
    }
    public void enermyBePoison(int posion)
    {
        enermy.poison += posion;
    }
}
