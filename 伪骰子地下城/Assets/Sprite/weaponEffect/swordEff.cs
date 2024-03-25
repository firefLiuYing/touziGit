using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordEff : MonoBehaviour
{
    battleControl battleControl;
    weaponInfo info;
    weaponExcute Excute;
    void Start()
    {
        battleControl = GameObject.Find("battleControl")
            .GetComponent<battleControl>();
        info=GetComponent<weaponInfo>();
        Excute=GetComponent<weaponExcute>();
        Excute.excute += effect;
    }
    public void effect()
    {
        int count =
        beChoseControl.touzis[0].count;
        battleControl.playerHit(count);
    }
}
