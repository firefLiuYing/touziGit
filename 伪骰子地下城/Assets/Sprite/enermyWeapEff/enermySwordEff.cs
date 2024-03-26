using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermySwordEff : MonoBehaviour
{
    public battleControl control;
    enermyWeaponDeath weapon;
    void Start()
    {
        control=GameObject.Find("battleControl").GetComponent<battleControl>();
        weapon=GetComponent<enermyWeaponDeath>();
        weapon.excute += effect;
    }
    void effect()
    {
        control.enermyHit(weapon.touziCount);
    }
    void Update()
    {
        
    }
}
