using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class HPprint : MonoBehaviour
{
    public Slider HPbar;
    public TextMeshProUGUI HPvalue;
    battleInfo info;
    void Start()
    {
        info=GetComponent<battleInfo>();   
    }
    void Update()
    {
        HpPrint();
    }
    int maxHP;
    int curHP;
    void HpPrint()
    {
        maxHP = info.maxHP;
        curHP=info.curHP;
        HPbar.value = ((float)curHP)/((float)maxHP);
        HPvalue.text = curHP.ToString()+"/"+maxHP.ToString();
    }
}
