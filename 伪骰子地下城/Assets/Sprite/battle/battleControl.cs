using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleControl : MonoBehaviour
{
    public battleInfo player;
    public battleInfo enermy;
    public GameObject successUI;
    public GameObject lostUI;
    void Start()
    {
        touzis = loadPref.getPref("touzi");
        creatTouzi(count);
    }
    void Update()
    {
        resultCalculate();
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
    void playerTurnStart()
    {
        creatTouzi(count);
    }
    void enermyBehave()
    {
        playerTurnStart();
    }
    public void onClickNext()
    {
        for(int i = 0; i < autoSort.touzis.Count; i++)
        {
            autoSort.touzis[i].beUsed = true;
        }
        enermyBehave();
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
    public void enermyHit(int hurt)
    {
        player.curHP -= hurt;
    }
}
