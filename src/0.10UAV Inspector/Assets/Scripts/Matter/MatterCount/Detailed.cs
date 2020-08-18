using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detailed : MonoBehaviour
{
    private GameObject m_Inform;
    private GameObject m_Inform2;
    private GameObject m_Exist;

    public bool isClick = false;
    public bool isNotExist = true;

    private GameObject m_Canvas;
    private string m_No;

    public string locationName;
    public string typeName;
    public string boardName;
    public string shelfName;
   
    public string flyName;
    public string[] result;

    public string type;
    public string shelf;
    public string board;
    public string location;
    // Start is called before the first frame update
    void Start()
    {
        isNotExist = true;
    }
    public void Click()
    {
        m_No = this.GetComponentInChildren<Text>().text;
        m_Exist = GameObject.Find("Information Of Matter" + m_No);
        m_Canvas = GameObject.Find("Canvas");

        if (m_Exist)
        {
            isNotExist = false;
            m_Exist = GameObject.Find("Canvas");

        }
        else { isNotExist = true; }

        
        
        if (isNotExist)
        {


            
            m_Inform = GameObject.Find("MatterInformation");
            
            m_Inform2 = Instantiate(m_Inform);
            m_Inform2.transform.name = "Information Of Matter" + m_No;
            m_Inform2.transform.SetParent(GameObject.Find("ForDestroy").transform);
            m_Inform2.transform.position = m_Inform.transform.position;
            m_Inform2.transform.rotation = m_Inform.transform.rotation;
            m_Inform2.transform.localScale = m_Inform.transform.localScale;
            m_Inform2.GetComponent<Drag>().enabled = true;

            m_Inform2.GetComponent<CanvasGroup>().alpha = 1;

            m_Inform2.transform.Find("MatterInform").transform.Find("MatterNo").GetComponent<Text>().text = "货物编号：" + m_No;
            result = m_No.Split('-');
            
            type = result[1].Substring(0, 2);
            switch (type)
            {
                case "T1": typeName = "内存DDR8GB"; break;
                case "T2": typeName = "内存DDR16GB"; break;
                case "T3": typeName = "内存DDR32GB"; break;
                case "T4": typeName = "硬盘HDD1TB"; break;
                case "T5": typeName = "硬盘SSD256GB"; break;
                case "T6": typeName = "硬盘SSD512GB"; break;
            }
            shelf = result[1].Substring(2, 2);
            switch (shelf)
            {
                case "S1": shelfName = "第一货架"; flyName = "一号飞机"; break;
                case "S2": shelfName = "第二货架"; flyName = "一号飞机"; break;
                case "S3": shelfName = "第三货架"; flyName = "一号飞机"; break;
                case "S4": shelfName = "第四货架"; flyName = "一号飞机"; break;
                case "S5": shelfName = "第五货架"; flyName = "二号飞机"; break;
                case "S6": shelfName = "第六货架"; flyName = "二号飞机"; break;
                case "S7": shelfName = "第七货架"; flyName = "二号飞机"; break;
                case "S8": shelfName = "第八货架"; flyName = "二号飞机"; break;

            }
            board = result[1].Substring(4, 2);
            switch (board)
            {
                case "B1": boardName = "第一层"; break;
                case "B2": boardName = "第二层"; break;
                case "B3": boardName = "第三层"; break;
                case "B4": boardName = "第四层"; break;

            }
            location = result[1].Substring(6, 2);
            switch (location)
            {
                case "L1": locationName = "前侧第一个"; break;
                case "L2": locationName = "前侧第二个"; break;
                case "L3": locationName = "前侧第三个"; break;
                case "L4": locationName = "前侧第四个"; break;
                case "R1": locationName = "后侧第一个"; break;
                case "R2": locationName = "后侧第二个"; break;
                case "R3": locationName = "后侧第三个"; break;
                case "R4": locationName = "后侧第四个"; break;

            }


            m_Inform2.transform.Find("MatterInform").transform.Find("MatterType").GetComponent<Text>().text = "货物类型：" + typeName;
            m_Inform2.transform.Find("MatterInform").transform.Find("MatterShelf").GetComponent<Text>().text = "货架：" + shelfName;
            m_Inform2.transform.Find("MatterInform").transform.Find("MatterLocation").GetComponent<Text>().text = "货物位置：" + boardName +locationName;
            m_Inform2.transform.Find("MatterInform").transform.Find("MatterFly").GetComponent<Text>().text = "记录飞机：" + flyName;
            isNotExist = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
