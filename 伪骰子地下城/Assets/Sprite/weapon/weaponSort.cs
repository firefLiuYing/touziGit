using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSort : MonoBehaviour
{
    public static List<weaponDeath> weapons
        = new List<weaponDeath>();
    void Start()
    {
        fixToScreen();
    }
    void Update()
    {
        autoSort();
    }
    int W = 3840;
    int screenW;
    void fixToScreen()
    {
        screenW = Screen.width;
        deltaWidth *= ((float)screenW) / W;
    }
    public float deltaWidth;
    void autoSort()
    {
        for(int i = 0; i < weapons.Count; i++)
        {
            weapons[i].transform.position=
            transform.position+Vector3.right*deltaWidth*i;
        }
    }
}
