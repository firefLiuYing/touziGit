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
    IEnumerator autoBattle()
    {
        float t = 0;
        for (int i = 0; i < enermyTouziSort.touzis.Count; i++)
        {
            while (t <= 0.5)
            {
                t += Time.deltaTime;
                yield return null;
            }
            t = 0;
            int touziCount = enermyTouziSort.touzis[i].count;
            for (int j = 0; j < enermyWeaponSort.weapons.Count; j++)
            {
                while (t <= 0.01)
                {
                    t += Time.deltaTime;
                    yield return null;
                }
                t = 0;
                enermyWeaponDetermine deter = enermyWeaponSort.weapons[j].
                    GetComponent<enermyWeaponDetermine>();
                if (deter.ifUseful(touziCount))
                {
                    enermyTouziInfo info = enermyTouziSort.touzis[i];
                    enermyTouziSort.touzis.Remove(info);
                    info.transform.position=
                        enermyWeaponSort.weapons[j].transform.position;
                    while (t <= 0.01)
                    {
                        t += Time.deltaTime;
                        yield return null;
                    }
                    t = 0;
                    enermyWeaponSort.weapons[j].touziCount = touziCount;
                    enermyWeaponSort.weapons[j].beUse = true;
                    info.beUsed = true;
                    break;
                }
            }
        }
        while (t <= 0.5)
        {
            t += Time.deltaTime;
            yield return t;
        }
        t = 0;
        Invoke("enermyTurnEnd", 1);
    }
    void enermyAuto()
    {
        StartCoroutine(autoBattle());
    }
    void creatWeapon()
    {
        
        for (int i = 0;i<enermyWeaponBag.weapons.Count;i++)
        {
            GameObject weapon = Instantiate
                (enermyWeaponBag.weapons[i]);
            enermyWeaponSort.weapons.Add(weapon.
                GetComponent<enermyWeaponDeath>());
        }
        Invoke("enermyAuto", 1);
    }
    void enermyTurnEnd()
    {
        for(int i = 0;i<enermyTouziSort.touzis.Count;i++)
        {
            enermyTouziSort.touzis[i].beUsed = true;
        }
        for(int i = 0;i<enermyWeaponSort.weapons.Count; i++)
        {
            enermyWeaponSort.weapons[i].count = -1;
        }
        Invoke("startNext", 1);
    }
    void startNext()
    {
        control.playerTurnStart();
    }
    public void enermyTurnStart()
    {
        creatTouzi(count);
        /*creatWeapon();*/
        /*enermyAuto();*/
        /*enermyTurnEnd();*/
        /*startNext();*/
    }
    GameObject touzis;
    public int count;
    void creatTouzi(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject touzi = Instantiate(touzis);
            enermyTouziSort.touzis.Add(touzi.
                GetComponent<enermyTouziInfo>());
        }
        Invoke("creatWeapon", 1);
    }
}
