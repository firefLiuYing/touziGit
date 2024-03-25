using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponInfo : MonoBehaviour
{
    weaponExcute Excute;
    void Start()
    {
        Excute = GetComponent<weaponExcute>();
        if (!isCountless)
        {
            Excute.excute += deathCalculat;
        }
    }
    void Update()
    {
        
    }
    public bool isCountless;
    public int count=1;
    public bool beUsed=false;
    public void deathCalculat()
    {
        count--;
        if (count <= 0)
        {
            beUsed = true;
        }
    }
}
