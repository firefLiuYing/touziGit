using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPos : MonoBehaviour
{
    public static Transform pos;
    public static cellInfo curCell;
    public cellInfo start;
    void Start()
    { 
        pos=GetComponent<Transform>();
        curCell = start;
        pos.position = start.transform.position;
    }
}
