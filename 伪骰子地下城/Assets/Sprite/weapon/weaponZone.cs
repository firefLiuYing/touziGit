using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponZone : MonoBehaviour
{
    RectTransform Rtransform;
    Rect rect;
    void Start()
    {
        fixToScreen();
        Rtransform = GetComponent<RectTransform>();
        rect = Rtransform.rect;
        rect.center = transform.position;
    }
    void Update()
    {
        ifinImage();
    }
    void addToBag(modInfo info)
    {
        curH += info.height;
        info.beChose = true;
        weaponBag.weapons.Add(info.weapon);
        if(info.height==2)
            info.transform.position=transform.position;
        else if(info.height==1)
        {
            if (curH == 1)
                info.transform.position = transform.position 
                    + fix*Vector3.up * rect.height / 4;
            if (curH == 2)
                info.transform.position = transform.position 
                    + fix*Vector3.down * rect.height / 4;
        }
        weaponLib.beChoseMod.Remove(info);
    }
    int H = 2160;
    int screenH;
    float fix;
    void fixToScreen()
    {
        screenH = Screen.height;
        fix= ((float)screenH) / H;
    }
    void removeToBag(modInfo info)
    {
        curH -= info.height;
        info.beChose = false;
        weaponBag.weapons.Remove(info.weapon);
        weaponLib.beChoseMod.Add(info);
    }
    int maxH = 2;
    int curH = 0;
    void ifinImage()
    {
        if (rect.Contains(Input.mousePosition))
        {
            if (weaponLib.beChoseMod.Count > 0)
            {
                if (Input.GetMouseButtonUp(0))
                    if (!weaponLib.beChoseMod[0].beChose)
                        if(weaponLib.beChoseMod[0].height+curH<=maxH)
                            addToBag(weaponLib.beChoseMod[0]);
                if (Input.GetMouseButtonDown(0))
                    if (weaponLib.beChoseMod[0].beChose)
                        removeToBag(weaponLib.beChoseMod[0]);
            }
        }
    }
}
