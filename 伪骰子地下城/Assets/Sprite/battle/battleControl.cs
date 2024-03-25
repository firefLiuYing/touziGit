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
