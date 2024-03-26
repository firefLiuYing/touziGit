using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerMPprint : MonoBehaviour
{
    public Slider MPbar;
    public TextMeshProUGUI MPvalue;
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
    void mpPrint()
    {
        MPbar.value = ((float)curMP) / maxMP;
        MPvalue.text=curMP.ToString()+"/"+maxMP.ToString();
    }
    void MPfix()
    {
        if(curMP<=0)
            curMP=0;
        if(curMP>=maxMP)
            curMP=maxMP;
    }
}
