using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponDetermine : MonoBehaviour
{
    Rect radius;
    RectTransform Rtransform;
    void Start()
    {
        Rtransform = GetComponent<RectTransform>();
        radius = Rtransform.rect;
        radius.center = transform.position;
    }
    void Update()
    {
        updateRadius();
        touziDeter();
    }
    bool isUseful(int count)
    {
        if (count<beUseful.Count)
            return beUseful[count];
        else
        {
            return false;
        }
    }
    public List<bool> beUseful = new List<bool>();
    void touziDeter()
    {
        if (radius.Contains(Input.mousePosition))
        {
            if (beChoseControl.touzis.Count > 0)
            {
                beChoseControl.touzis[0].isfit=
                    isUseful(beChoseControl.touzis[0].count);
            }
        }
    }
    void updateRadius()
    {
        radius.center = transform.position;
    }
}
