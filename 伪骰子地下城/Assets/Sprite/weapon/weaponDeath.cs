using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponDeath : MonoBehaviour
{
    weaponInfo info;
    void Start()
    {
        transform.SetParent(GameObject.Find
            ("weaponUI").transform);
        info=GetComponentInChildren<weaponInfo>();
    }
    void Update()
    {
        ifdeath();
    }
    void ifdeath()
    {
        if(info.beUsed)
        {
            weaponSort.weapons.Remove(this);
            Destroy(gameObject);
        }
    }
}
