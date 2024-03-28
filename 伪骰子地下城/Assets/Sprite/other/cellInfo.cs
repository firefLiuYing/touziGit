using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellInfo : MonoBehaviour
{
    int tpyes;
    public List<cellInfo> connectCells = new List<cellInfo>();
    static int count = 0;
    void Start()
    {
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
        while(t<0.1)
        {
            t += Time.deltaTime;
            yield return null;
        }
        if(count<5)
        {
            int direct=(int)Random.Range(1,4);
            creatCell(direct);
        }
    }
    public float deltaW;
    public float deltaH;
    void creatCell(int direct)
    {
        count++;
        GameObject cell= Instantiate(cells);
        if (direct==1)
            cell.transform.position = transform.position + Vector3.right * deltaW;
        else if(direct==2)
            cell.transform.position=transform.position + Vector3.up * deltaH;
        else if (direct == 3)
            cell.transform.position = transform.position + Vector3.down * deltaH;
        cellInfo info = cell.GetComponent<cellInfo>();
        connectCells.Add(info);
        info.connectCells.Add(this);
    }
    void Update()
    {
        clickDete();
    }
    void onClick()
    {
        for(int i = 0; i < connectCells.Count; i++)
        {
            if (connectCells[i] ==playerPos.curCell)
                move();
        }
    }
    void move()
    {
        playerPos.pos.position=transform.position;
        playerPos.curCell = this;
    }
    RectTransform Rtransform;
    Rect rect;
    void clickDete()
    {
        if (rect.Contains(Input.mousePosition) && Input.GetMouseButton(0))
            onClick();
    }
}
