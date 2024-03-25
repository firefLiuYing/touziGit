using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoFix : MonoBehaviour
{
    float scaleX;
    float scaleY;
    float scaleZ;
    void Start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        scaleZ = transform.localScale.z;
        fixToScreen();
    }
    int W=3840;
    int H=2160;
    int screenW;
    int screenH;
    void fixToScreen()
    {
        screenW = Screen.width;
        screenH = Screen.height;
        transform.localScale=new Vector3
            (scaleX*screenW/W,scaleY*screenH/H,scaleZ);
    }
    void Update()
    {
        
    }
}
