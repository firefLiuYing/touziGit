using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyBehavior : MonoBehaviour
{
    battleControl battleControl;
    void Start()
    {
        touzis = loadPref.getPref("touzi");
        battleControl =GetComponent<battleControl>();
        battleControl.enermyBeH += enermyTurnStart;
    }
    void Update()
    {
        
    }
    GameObject touzis;
    void creatTouzi(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject touzi = Instantiate(touzis);
            enermyTouziSort.touzis.Add(touzi.
                GetComponent<touziInfo>());
        }
    }
    public int count;
    void enermyTurnStart()
    {
        creatTouzi(count);
    }
}
