using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyWeaponDetermine : MonoBehaviour
{
    void Start()
    {
        
    }
    public List<bool> beUseful=new List<bool>();
    public bool ifUseful(int count)
    {
        if(count<beUseful.Count)
            return beUseful[count];
        else return false;
    }
}
