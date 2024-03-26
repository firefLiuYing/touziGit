using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleInfo : MonoBehaviour
{
    public int maxHP;
    public int curHP;
    void Start()
    {
        curHP = maxHP;
        freeze = 0;
        poison = 0;
        rage= 0;
    }
    void Update()
    {
        HPfix();
    }
    public int freeze;
    public int poison;
    public int rage;
    void HPfix()
    {
        if(curHP<0) curHP = 0;
        if(curHP > maxHP) curHP = maxHP;
    }
}
