using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleControl : MonoBehaviour
{
    public battleInfo player;
    public battleInfo enermy;
    void Start()
    {
        touzis = loadPref.getPref("touzi");
        creatTouzi(count);
    }
    void Update()
    {
        
    }
    public void onClickNext()
    {
        for(int i = 0; i < autoSort.touzis.Count; i++)
        {
            autoSort.touzis[i].beUsed = true;
        }
    }
    GameObject touzis;
    public int count;
    void creatTouzi(int count)
    {
        for(int i = 0; i < count; i++)
        {
            touzis = Instantiate(touzis);
            autoSort.touzis.Add(touzis.
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
