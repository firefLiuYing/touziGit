using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyBehavior : MonoBehaviour
{
    void Start()
    {
        touzis = loadPref.getPref("touzis");
    }
    void Update()
    {
        
    }
    GameObject touzis;
    void creatTouzis(int count)
    {
        for(int i = 0; i < count; i++)
        {
            GameObject touzi=Instantiate(touzis);
            enermyTouziSort.touzis.Add(
                touzi.GetComponent<touziInfo>());
        }
    }
    public int count;
    void enermyTurnStart()
    {
        creatTouzis(count);
    }
}
