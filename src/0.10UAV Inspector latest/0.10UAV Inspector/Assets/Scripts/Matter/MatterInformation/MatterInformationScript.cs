using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatterInformationScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject m_Inform;
    private GameObject m_Inform2;
    private GameObject m_Exist;

    public bool isClick = false;
    public bool isNotExist = true;

    private GameObject m_Canvas;
    private int m_No;

    private void OnMouseDown()
    {
        m_No = this.GetComponent<MatterCatched>().No;
        m_Exist = GameObject.Find("Information Of Matter" + " No." + m_No);
        m_Canvas = GameObject.Find("Canvas");

        if (m_Exist)
        {
            isNotExist = false;
            m_Exist = GameObject.Find("Canvas");
            
        }
        else { isNotExist = true; }
        
        if (isNotExist & m_No!=0 & m_Canvas.GetComponent<Canvas>().enabled & GameObject.Find("MainCamera").GetComponent<Camera>().enabled)
        {
            isClick = true;
        }
  
    }
    private void OnGUI()
    {
        if (isClick)
        {

            

            m_Inform = GameObject.Find("MatterInformation");

            m_Inform2 = Instantiate(m_Inform);
            m_Inform2.transform.name = "Information Of Matter" + " No." +m_No;
            m_Inform2.transform.parent = m_Canvas.transform;
            m_Inform2.transform.position = m_Inform.transform.position;
            m_Inform2.transform.rotation = m_Inform.transform.rotation;
            m_Inform2.transform.localScale = m_Inform.transform.localScale;
            m_Inform2.GetComponent<Drag>().enabled = true;
            m_Inform2.GetComponent<CanvasGroup>().alpha = 1;

            m_Inform2.transform.Find("MatterInform").transform.Find("MatterNo").GetComponent<Text>().text = "货物编号：" +"No."+ m_No+GetComponent<property>().fly + "-" + "T" + GetComponent<property>().type+ "S" + GetComponent<property>().shelf  + "B" + GetComponent<property>().board  + GetComponent<property>().No;
            m_Inform2.transform.Find("MatterInform").transform.Find("MatterType").GetComponent<Text>().text = "货物类型：" + GetComponent<property>().typeName;
            m_Inform2.transform.Find("MatterInform").transform.Find("MatterShelf").GetComponent<Text>().text = "货架：" + GetComponent<property>().shelfName;
            m_Inform2.transform.Find("MatterInform").transform.Find("MatterLocation").GetComponent<Text>().text = "货物位置：" + GetComponent<property>().boardName + GetComponent<property>().locationName;
            m_Inform2.transform.Find("MatterInform").transform.Find("MatterFly").GetComponent<Text>().text = "记录飞机：" + GetComponent<property>().flyName;
            isClick = false;

        }
            }


    // Update is called once per frame
    void Update()
            {

            }
        } 
