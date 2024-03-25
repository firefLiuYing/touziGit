using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponExcute : MonoBehaviour
{
    weaponInfo info;
    RectTransform Rtransform;
    void Start()
    {
        info = GetComponent<weaponInfo>();
        excute += aiuhdiua;
        Rtransform = GetComponent<RectTransform>();
        rect = Rtransform.rect;
        rect.center=transform.position;
    }
    int a = 0;
    void aiuhdiua()
    {
        a++;
    }
    void Update()
    {
        ifinImage();
    }
    Rect rect;
    void ifinImage()
    {
        if (rect.Contains(Input.mousePosition))
        {
            if (Input.GetMouseButtonUp(0))
            {
                if(beChoseControl.touzis.Count>0)
                {
                    excute();
                }
            }
        }
    }
    public Action excute;
}
