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
    public Rect rect;
    public bool isin;
    public Vector2 pos;
    void ifinImage()
    {
        pos = Input.mousePosition;
        isin = rect.Contains(Input.mousePosition);
        if (rect.Contains(Input.mousePosition))
        {
            if (Input.GetMouseButtonUp(0))
            {
                excute();
            }
        }
    }
    public Action excute;
}
