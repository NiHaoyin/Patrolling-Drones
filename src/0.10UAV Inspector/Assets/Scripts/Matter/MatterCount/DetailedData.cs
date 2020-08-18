using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailedData : MonoBehaviour
{
    public int number;
    public int countingNumber;

    private GameObject m_MatterButton;
   

    private GameObject m_Button;

    private GameObject m_MatterNo;
    private GameObject m_MatterNo1;
    private GameObject m_MatterNo2;
    private GameObject m_MatterNo3;
    private GameObject m_MatterNo4;
    private GameObject m_MatterNo5;
    private GameObject m_MatterNo6;

    private int[] m_NoArray = new int[100];
    private int[] m_typeArray = new int[100];
    private int[] m_shelfArray = new int[100];
    private int[] m_boardArray = new int[100];
    private string[] m_locationArray = new string[100];


    public Vector3 offset;

    public int type;

    // Start is called before the first frame update
    void Start()
    {
        m_MatterNo1 = GameObject.Find("Matter1");
        m_MatterNo2 = GameObject.Find("Matter2");
        m_MatterNo3 = GameObject.Find("Matter3");
        m_MatterNo4 = GameObject.Find("Matter4");
        m_MatterNo5 = GameObject.Find("Matter5");
        m_MatterNo6 = GameObject.Find("Matter6");

        m_MatterButton = this.transform.Find("DetailedMatter1").gameObject;
          

        



    }

    // Update is called once per frame
    void Update()
    {
        
        if (type != 0)
        {
            switch(type)
            {
                case 1:   m_MatterNo = m_MatterNo1; break;
                case 2: m_MatterNo = m_MatterNo2; break;
                case 3:  m_MatterNo = m_MatterNo3; break;
                case 4:m_MatterNo = m_MatterNo4;break;
                case 5: m_MatterNo = m_MatterNo5; break;
                case 6: m_MatterNo = m_MatterNo6; break;
            }
            m_NoArray=m_MatterNo.GetComponentInChildren<MatterNumber>().numberArray;
            m_typeArray = m_MatterNo.GetComponentInChildren<MatterNumber>().typeArray;
            m_shelfArray = m_MatterNo.GetComponentInChildren<MatterNumber>().shelfArray;
            m_boardArray = m_MatterNo.GetComponentInChildren<MatterNumber>().boardArray;
            m_locationArray = m_MatterNo.GetComponentInChildren<MatterNumber>().locationArray;
            number = m_MatterNo.GetComponentInChildren<MatterNumber>().number;
            for (; countingNumber < number; countingNumber++)
            {
                m_Button = Instantiate(m_MatterButton);

                m_Button.transform.name = "DetailedMatter" +type+ " No." +m_NoArray[countingNumber] ;
                m_Button.transform.SetParent(GameObject.Find("ForDestroy").transform);
                m_Button.transform.rotation = m_MatterButton.transform.rotation;
                m_Button.transform.localScale = m_MatterButton.transform.localScale;
                m_Button.GetComponent<CanvasGroup>().alpha = 1;
                if (m_shelfArray[countingNumber] <= 4)
                {
                    m_Button.GetComponentInChildren<Text>().text = "No." + m_NoArray[countingNumber] + "F"+"-" + "T" + m_typeArray[countingNumber] + "S" + m_shelfArray[countingNumber] + "B" + m_boardArray[countingNumber] + m_locationArray[countingNumber];
                }
                else
                {
                    m_Button.GetComponentInChildren<Text>().text = "No." + m_NoArray[countingNumber] + "FF" + "-" + "T" + m_typeArray[countingNumber] + "S" + m_shelfArray[countingNumber] + "B" + m_boardArray[countingNumber] + m_locationArray[countingNumber];
                }

                if (countingNumber < 15)
                {
                    offset.x = -500;
                    offset.y = 170-35*countingNumber;
                    offset.z = 0;
                    m_Button.transform.localPosition = offset;
                }

                if (countingNumber >= 15 & countingNumber < 30)
                {
                    offset.x = -80;
                    offset.y = 170 - 35 * (countingNumber-15);
                    offset.z = 0;
                    m_Button.transform.localPosition = offset;
                }

                if (countingNumber >= 30 & countingNumber < 45)
                {
                    offset.x = 340;
                    offset.y = 170 - 35 * (countingNumber-30);
                    offset.z = 0;
                    m_Button.transform.localPosition = offset;
                }

                if (countingNumber >= 45 & countingNumber < 60)
                {
                    offset.x = 760;
                    offset.y = 170 - 35 * (countingNumber-45);
                    offset.z = 0;
                    m_Button.transform.localPosition = offset;
                }

                if (countingNumber >= 60 & countingNumber < 75)
                {
                    offset.x = 1180;
                    offset.y = 170 - 35 * (countingNumber-60);
                    offset.z = 0;
                    m_Button.transform.localPosition = offset;
                }
            }
        }     
            
    }
}
