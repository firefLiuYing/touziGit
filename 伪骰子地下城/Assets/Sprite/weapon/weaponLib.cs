using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponLib : MonoBehaviour
{
    public static List<GameObject> weapons
        = new List<GameObject>();
    public static modInfo mod;
    public static GameObject weaponChooseUI;
    public GameObject weap;
    void Start()
    {
        weaponChooseUI = weap;
    }
    void Update()
    {
        
    }
}
