using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class touziInfo : MonoBehaviour
{
    public TextMeshProUGUI countValue;
    void Start()
    {
        count = Random.Range(1, 7);
        valuePrint();
        autoSort.touzis.Add(this);
    }
    public bool isfit = true;
    public int count;
    void Update()
    {
        death();
    }
    void death()
    {
        if(beUsed)
        {
            beChoseControl.touzis.Remove(this);
            Destroy(gameObject); 
            beUsed = false;
        }
    }
    public bool beUsed=false;
    void valuePrint()
    {
        countValue.text = count.ToString();
    }
}
