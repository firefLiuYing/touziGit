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
    public void beDrag()
    {
        //还没写条件
        transform.position = Input.mousePosition;
    }
    public void beClickDown()
    {
        beChoseControl.touzis.Add(info);
    }
}
