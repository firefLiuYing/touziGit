using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponBag : MonoBehaviour
{
    public static List<GameObject> weapons
        = new List<GameObject>();
    void Start()
    {
        weapons.Add(loadPref.getPref("sword"));
        weapons.Add(loadPref.getPref("knife"));
    }
    void Update()
    {
        
    }
}
