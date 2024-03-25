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
    }
    public bool isfit = true;
    public int count;
    void Update()
    {
        
    }
    void valuePrint()
    {
        countValue.text = count.ToString();
    }
}
