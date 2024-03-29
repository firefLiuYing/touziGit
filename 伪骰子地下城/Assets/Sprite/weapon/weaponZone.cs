using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponZone : MonoBehaviour
{
    RectTransform Rtransform;
    public Rect rect;
    void Start()
    {
        Rtransform = GetComponent<RectTransform>();
        fixToScreen();
    }
    public Vector2 mouse;
    void Update()
    {
        upDatePos();
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
                    +Vector3.up * rect.height / 4;
            }
            else
            {
                info.transform.position = transform.position
                    + Vector3.down * rect.height / 4;
            }
        }
        
    }
    int H = 2160;
    int W = 3840;
    int screenH;
    int screenW;
    float fix;
    void fixToScreen()
    {
        rect = Rtransform.rect;
        screenH = Screen.height;
        screenW = Screen.width;
        fix= ((float)screenH) / H;
        rect.height *= ((float)screenH) / H;
        rect.width *= ((float)screenW) / W;
    }
    void upDatePos()
    {
        rect.center = transform.position;
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
        mouse=Input.mousePosition;
        if (rect.Contains(Input.mousePosition))
        {
            if (weaponLib.mod)
            {
                if (Input.GetMouseButtonUp(0))
                    if (!weaponLib.mod.beChose)
                        if(weaponLib.mod.height+curH<=maxH)
                            StartCoroutine( addToBag(weaponLib.mod));
                if (Input.GetMouseButtonDown(0))
                    if (weaponLib.mod.beChose)
                        removeToBag(weaponLib.mod);
            }
        }
    }
}
