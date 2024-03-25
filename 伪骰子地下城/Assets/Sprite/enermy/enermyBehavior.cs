using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyBehavior : MonoBehaviour
{
    battleControl control;
    void Start()
    {
        touzis = loadPref.getPref("enerTouzi");
        control = GetComponent<battleControl>();
        control.enermyBeH += enermyTurnStart;
    }
    void Update()
    {
        
    }
    void enermyTurnStart()
    {
        creatTouzi(count);
    }
    GameObject touzis;
    public int count;
    void creatTouzi(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject touzi = Instantiate(touzis);
            enermyTouziSort.touzis.Add(touzi.
                GetComponent<touziInfo>());
        }
    }
}
