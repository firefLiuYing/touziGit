using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSort : MonoBehaviour
{
    public static List<weaponDeath> weapons
        = new List<weaponDeath>();
    void Start()
    {
        
    }
    void Update()
    {
        autoSort();
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
