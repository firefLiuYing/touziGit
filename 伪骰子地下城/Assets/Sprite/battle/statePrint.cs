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
        state.text = (info.rage > 0 ? "¿ñÅ­" : "") + (info.freeze > 0 ?
            ("±ù¶³ " + info.freeze.ToString()) : "") + (info.poison > 0 ?
            ("ÖÐ¶¾ " + info.poison.ToString()) : "");
    }
}
