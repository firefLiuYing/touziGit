using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollEff : MonoBehaviour
{
    battleControl battleControl;
    weaponInfo info;
    weaponExcute Excute;
    void Start()
    {
        touzis = loadPref.getPref("touzi");
        battleControl = GameObject.Find("battleControl")
            .GetComponent<battleControl>();
        info = GetComponent<weaponInfo>();
        Excute = GetComponent<weaponExcute>();
        Excute.excute += effect;
    }
    public void effect()
    {
        int count =
        beChoseControl.touzis[0].count;
        beChoseControl.touzis[0].beUsed = true;
        creatTouzi(1);
        if (battleControl.player.rage > 0)
        {
            creatTouzi(1);
            battleControl.player.rage--;
        }
    }
    GameObject touzis;
    void creatTouzi(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject touzi = Instantiate(touzis);
            autoSort.touzis.Add(touzi.
                GetComponent<touziInfo>());
        }
    }
}
