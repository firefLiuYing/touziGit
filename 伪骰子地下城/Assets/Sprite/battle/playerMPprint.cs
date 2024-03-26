using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerMPprint : MonoBehaviour
{
    public Slider MPbar;
    battleInfo info;
    public int curMP;
    public int maxMP;
    void Start()
    {
        info=GetComponent<battleInfo>();
    }
    void Update()
    {
        MPfix();
        mpPrint();
    }
    public void endSkill()
    {
        if(curMP==maxMP)
        {
            info.rage++;
            curMP = 0;
        }
    }
    void mpPrint()
    {
        MPbar.value = ((float)curMP) / maxMP;
    }
    void MPfix()
    {
        if(curMP<=0)
            curMP=0;
        if(curMP>=maxMP)
            curMP=maxMP;
    }
}
