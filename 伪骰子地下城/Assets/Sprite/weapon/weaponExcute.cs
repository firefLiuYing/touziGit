using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponExcute : MonoBehaviour
{
    weaponInfo info;
    void Start()
    {
        info = GetComponent<weaponInfo>();
        excute += aiuhdiua;
    }
    int a = 0;
    void aiuhdiua()
    {
        a++;
    }
    void Update()
    {
        
    }
    public Action excute;
    public void onClickUp()
    {
        if(beChoseControl.touzis.Count>0)
        {
            if (beChoseControl.touzis[0].isfit)
            {
                excute();
            }
        }
    }

}
