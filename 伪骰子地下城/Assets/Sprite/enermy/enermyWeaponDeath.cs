using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyWeaponDeath : MonoBehaviour
{
    public bool beCountless;
    public int count;
    public bool beUse=false;
    public int touziCount;
    void Start()
    {
        transform.SetParent(GameObject.Find
            ("weaponUI").transform);
        beUse = false;
    }
    void Update()
    {
        Excute();
        death();
    }
    public Action excute;
    void Excute()
    {
        if(beUse)
        {
            excute();
            if (!beCountless)
                count--;
            beUse =false;
        }
    }
    void death()
    {
        if(count<=0)
        {
            enermyWeaponSort.weapons.Remove(this);
            Destroy(gameObject);
        }
    }
}
