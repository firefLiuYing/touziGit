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
    }
    void Update()
    {
        HPfix();
    }
    void HPfix()
    {
        if(curHP<0) curHP = 0;
        if(curHP > maxHP) curHP = maxHP;
    }
}
