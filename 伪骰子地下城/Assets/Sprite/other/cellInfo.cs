using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class cellInfo : MonoBehaviour
{
    int types;
    public List<cellInfo> connectCells = new List<cellInfo>();
    static int count = 0;
    public bool isFirst;
    void Start()
    {
        autofix();
        onClick += move;
        typePrint();
        transform.SetParent(GameObject.Find("map").transform);
        cells = loadPref.getPref("cell");
        Rtransform = GetComponent<RectTransform>();
        rect = Rtransform.rect;
        rect.center = transform.position;
        StartCoroutine(creatMap());
    }
    GameObject cells;
    IEnumerator creatMap()
    {
        float t = 0;
        while (t < 0.1)
        {
            t += Time.deltaTime;
            yield return null;
        }
        if (count < 5)
        {
            int direct = (int)Random.Range(1, 3);
            creatCell(direct);
        }
    }
    void typePrint()
    {
        types = (int)Random.Range(1, 5);
        if (isFirst) types = 0;
        if(count==4) types = 1;
        TextMeshProUGUI name = GetComponentInChildren<TextMeshProUGUI>();
        if (types == 1)
        {
            name.text = "Õ½¶·";
            onClick += battleButton;
        }
        else if (types == 2)
            name.text = "Æ»¹û";
        else
            name.text = "";
    }
    public float deltaW;
    public float deltaH;
    void creatCell(int direct)
    {
        count++;
        GameObject cell = Instantiate(cells);
        if (direct == 1)
            cell.transform.position = transform.position + Vector3.right * deltaW;
        else if (direct == 2)
            cell.transform.position = transform.position + Vector3.up * deltaH;
        else if (direct == 3)
            cell.transform.position = transform.position + Vector3.down * deltaH;
        cellInfo info = cell.GetComponent<cellInfo>();
        info.isFirst = false;
        connectCells.Add(info);
        info.connectCells.Add(this);
    }
    int W = 3840;
    int H = 2160;
    int screenW;
    int screenH;    
    void autofix()
    {
        if(!isFirst)
            gameObject.AddComponent<autoFix>();
        screenW = Screen.width;
        screenH = Screen.height;
        deltaW *= ((float)screenW) / W;
        deltaH *= ((float)screenH) / H;
    }
    void Update()
    {
        clickDete();
    }
    Action onClick;
    void battleButton()
    {
        GameObject.Find("map").SetActive(false);
    }
    void move()
    {
        playerPos.pos.position = transform.position;
        playerPos.curCell = this;
    }
    RectTransform Rtransform;
    Rect rect;
    void clickDete()
    {
        if (rect.Contains(Input.mousePosition) && Input.GetMouseButton(0))
        {
            for (int i = 0; i < connectCells.Count; i++)
            {
                if (connectCells[i] == playerPos.curCell)
                    onClick();
            }
        }
    }
}
