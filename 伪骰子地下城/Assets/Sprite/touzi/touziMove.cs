using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touziMove : MonoBehaviour
{
    touziInfo info;

    void Start()
    {
        info=GetComponent<touziInfo>();

    }
    void Update()
    {
        
    }
    public void beClickUp()
    {
        if(!info.beUsed)
        {
            autoSort.touzis.Add(info);
        }
        else
        {

        }
    }
    public void beDrag()
    {
        //��ûд����
        transform.position = Input.mousePosition;
    }
    public void beClickDown()
    {
        autoSort.touzis.Remove(info);
        beChoseControl.touzis.Add(info);
    }
}
