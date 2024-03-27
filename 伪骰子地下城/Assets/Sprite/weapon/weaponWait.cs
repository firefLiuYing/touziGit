using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponWait : MonoBehaviour
{
    public static List<modInfo> highWeaps = new List<modInfo>();
    public static List<modInfo> shortWeaps = new List<modInfo>();
    public Transform highPos;
    public Transform shortPos;
    public float deltWofH;
    public float deltHofH;
    public int maxWofH;
    public int maxWofS;
    public float deltWofS;
    public float deltHofS;
    public List<modInfo> weaps;
    void Start()
    {
        AddThem();
        fixToScreen();
    }
    void AddThem()
    {
        for(int i = 0; i < weaps.Count; i++)
        {
            if (weaps[i].height==2)
                highWeaps.Add(weaps[i]);
            if (weaps[i].height==1)
                shortWeaps.Add(weaps[i]);
        }
    }
    void Update()
    {
        autoSort();
    }
    int W = 3840;
    int H = 2160;
    int screenW;
    int screenH;
    void fixToScreen()
    {
        screenW = Screen.width;
        screenH = Screen.height;
        deltWofH *= ((float)screenW) / W;
        deltWofS *= ((float)screenW) / W;
        deltHofH *= ((float)screenH) / H;
        deltHofS *= ((float)screenH) / H;
    }
    void autoSort()
    {
        for(int i = 0; i < highWeaps.Count; i++)
        {
            highWeaps[i].transform.position = highPos.position
                + (i % maxWofH) * Vector3.right*deltWofH 
                + (i / maxWofH) * Vector3.down*deltHofH;
        }
        for(int i = 0;i < shortWeaps.Count;i++)
        {
            shortWeaps[i].transform.position= shortPos.position
                +(i%maxWofS) * Vector3.right*deltWofS
                +(i/maxWofS) * Vector3.down*deltHofS;
        }
    }
}
