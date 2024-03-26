using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyWeaponBag : MonoBehaviour
{
    public static List<GameObject> weapons
        = new List<GameObject>();
    private void Awake()
    {
        weapons.Add(loadPref.getPref("enerSword"));
        weapons.Add(loadPref.getPref("enerArrow"));
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
