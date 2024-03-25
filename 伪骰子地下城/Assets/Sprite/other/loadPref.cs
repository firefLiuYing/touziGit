using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadPref : MonoBehaviour
{
    static Dictionary<string,GameObject> prefs
        =new Dictionary<string,GameObject>();
    public static GameObject getPref(string name)
    {
        if (prefs.ContainsKey(name))
            return prefs[name];
        else
        {
            GameObject temp = Resources.Load<GameObject>
                ("prefab/" + name);
            prefs.Add(name, temp);
            return temp;
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
