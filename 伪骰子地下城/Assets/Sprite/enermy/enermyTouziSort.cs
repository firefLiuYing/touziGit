using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyTouziSort : MonoBehaviour
{
    public static List<touziInfo> touzis =
        new List<touziInfo>();
    public int widCount;
    public int maxCount;
    public float deltaWidth;
    public float deltaHeight;
    void Start()
    {
        fixToScreen();
    }
    void Update()
    {
        sortTouzi();
    }
    int W = 3840;
    int H = 2160;
    int screenW;
    int screenH;
    void fixToScreen()
    {
        screenW = Screen.width;
        screenH = Screen.height;
        deltaWidth *= ((float)screenW) / W;
        deltaHeight *= ((float)screenH) / H;
    }
    void sortTouzi()
    {
        for (int i = 0; i < touzis.Count; i++)
        {
            touzis[i].transform.position =
                transform.position + new Vector3
                (deltaWidth * (i % widCount),
                deltaHeight * (i / widCount));
        }
    }
}
