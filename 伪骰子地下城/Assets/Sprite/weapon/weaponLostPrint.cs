using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class weaponLostPrint : MonoBehaviour
{
    weaponInfo info;
    TextMeshProUGUI restTimes;
    void Start()
    {
        info=GetComponent<weaponInfo>();
        restTimes=GetComponentInChildren<TextMeshProUGUI>();
    }
    void Update()
    {
        resPrint();
    }
    void resPrint()
    {
        restTimes.text = "���غϿ�ʹ��"+info.count
            .ToString()+"��";
    }
}
