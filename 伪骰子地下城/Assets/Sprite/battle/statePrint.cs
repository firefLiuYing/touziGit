using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class statePrint : MonoBehaviour
{
    battleInfo info;
    public TextMeshProUGUI state;
    void Start()
    {
        info=GetComponent<battleInfo>();
    }
    void Update()
    {
        stateP();
    }
    void stateP()
    {
        state.text = (info.rage > 0 ? "��ŭ" : "") + (info.freeze > 0 ?
            ("���� " + info.freeze.ToString()) : "") + (info.poison > 0 ?
            ("�ж� " + info.poison.ToString()) : "");
    }
}
