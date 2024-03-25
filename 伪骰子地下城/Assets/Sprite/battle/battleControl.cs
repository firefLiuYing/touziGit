using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleControl : MonoBehaviour
{
    public battleInfo player;
    public battleInfo enermy;
    void Start()
    {
        
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
