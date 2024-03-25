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
        StartCoroutine(laterBack());
    }
    IEnumerator laterBack()
    {
        float time = 0;
        while(time<0.1f)
        {
            time += Time.deltaTime;
            yield return null;
        }
        if (!info.beUsed)
        {
            autoSort.touzis.Add(info);
            beChoseControl.touzis.Remove(info);
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
