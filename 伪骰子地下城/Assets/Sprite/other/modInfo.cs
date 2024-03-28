using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class modInfo : MonoBehaviour
{
    public string weaponName;
    public GameObject weapon;
    public int height;
    private void Awake()
    {
        weapon = loadPref.getPref(weaponName);
    }
    public bool beChose;
    void Start()
    {
        beChose = false;
    }
    public void OnMouseDown()
    {
        weaponLib.beChoseMod.Add(this);
        if(height==2)
            weaponWait.highWeaps.Remove(this);
        if(height==1)
            weaponWait.shortWeaps.Remove(this);
    }
    IEnumerator back()
    {
        float t = 0;
        while(t<0.1)
        {
            t += Time.deltaTime;
            yield return null;
        }
        weaponLib.beChoseMod.Remove(this);
        if (!beChose)
        {
            if (height == 2)
                weaponWait.highWeaps.Add(this);
            if (height == 1)
                weaponWait.shortWeaps.Add(this);
        }
    }
    public void OnMouseUp()
    {
        StartCoroutine(back());
    }
    public void OnDrag()
    {
        transform.position=Input.mousePosition;
    }
    void Update()
    {
        
    }
}
