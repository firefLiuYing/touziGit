using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponBag : MonoBehaviour
{
    public static List<GameObject> weapons
        = new List<GameObject>();
    private void Awake()
    {
        /*weapons.Add(loadPref.getPref("sword"));
        weapons.Add(loadPref.getPref("knife"));
        weapons.Add(loadPref.getPref("arrow"));
        weapons.Add(loadPref.getPref("crystal")); 
        weapons.Add(loadPref.getPref("roll"));
        weapons.Add(loadPref.getPref("claw"));*/
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
