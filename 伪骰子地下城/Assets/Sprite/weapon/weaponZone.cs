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
    IEnumerator addToBag(modInfo info)
    {
        float t = 0;
        while(t<0.05)
        {
            t += Time.deltaTime;
            yield return null;
        }
        curH += info.height;
        info.beChose = true;
        weaponBag.weapons.Add(info.weapon);
        if(info.height==2)
            info.transform.position=transform.position;
        else if(info.height==1)
        {
            if (Input.mousePosition.y>=transform.position.y)
            {
                info.transform.position = transform.position
                    + fix * Vector3.up * rect.height / 4;
            }
            else
            {
                info.transform.position = transform.position
                    + fix * Vector3.down * rect.height / 4;
            }
        }
        
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
    }
    int maxH = 2;
    public int curH = 0;
    void ifinImage()
    {
        if (rect.Contains(Input.mousePosition))
        {
            if (weaponLib.beChoseMod.Count > 0)
            {
                if (Input.GetMouseButtonUp(0))
                    if (!weaponLib.beChoseMod[0].beChose)
                        if(weaponLib.beChoseMod[0].height+curH<=maxH)
                            StartCoroutine( addToBag(weaponLib.beChoseMod[0]));
                if (Input.GetMouseButtonDown(0))
                    if (weaponLib.beChoseMod[0].beChose)
                        removeToBag(weaponLib.beChoseMod[0]);
            }
        }
    }
}
