using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enermyTouziInfo : MonoBehaviour
{
    public TextMeshProUGUI countValue;
    void Start()
    {
        transform.SetParent(GameObject.Find("touziUI").
            transform);
        count = Random.Range(1, 7);
    }
    public bool isfit = true;
    public int count;
    void Update()
    {
        valuePrint();
        death();
    }
    void death()
    {
        if (beUsed)
        {
            enermyTouziSort.touzis.Remove(this);
            Destroy(gameObject);
            beUsed = false;
        }
    }
    public bool beUsed = false;
    void valuePrint()
    {
        countValue.text = count.ToString();
    }
}
