using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counting : MonoBehaviour
{
    public int matter1No;
    public int matter2No;
    public int matter3No;
    public int matter4No;
    public int matter5No;
    public int matter6No;
    public int type;//物料传递

    private int m_Matter1;
    private int m_Matter2;
    private int m_Matter3;
    private int m_Matter4;
    private int m_Matter5;
    private int m_Matter6;

    private GameObject m_Matter1Count;
    private GameObject m_Matter2Count;
    private GameObject m_Matter3Count;
    private GameObject m_Matter4Count;
    private GameObject m_Matter5Count;
    private GameObject m_Matter6Count;

    private GameObject m_Copy;
    private Vector3 m_Offset;

    private GameObject m_TextMatter1;
    private GameObject m_TextMatter2;
    private GameObject m_TextMatter3;
    private GameObject m_TextMatter4;
    private GameObject m_TextMatter5;
    private GameObject m_TextMatter6;
    // Start is called before the first frame update
    void Start()
    {
        m_Offset.x = 50;
        m_Offset.y = 0;
        m_Offset.z = 0;

        m_Matter1Count = this.transform.Find("CountForM1InS1").gameObject;
        m_TextMatter1 = this.transform.Find("Text_CountForM1InS1").gameObject;

        m_TextMatter2 = Instantiate(m_TextMatter1);
        m_TextMatter2.transform.SetParent(this.transform);
        m_TextMatter2.transform.rotation = m_TextMatter1.transform.rotation;
        m_TextMatter2.transform.localScale = m_TextMatter1.transform.localScale;
        m_TextMatter2.GetComponent<Text>().text = ""+0 ;
        m_TextMatter2.transform.localPosition = m_Offset+m_TextMatter1.transform.localPosition;

        m_TextMatter3 = Instantiate(m_TextMatter1);
        m_TextMatter3.transform.SetParent(this.transform);
        m_TextMatter3.transform.rotation = m_TextMatter1.transform.rotation;
        m_TextMatter3.transform.localScale = m_TextMatter1.transform.localScale;
        m_TextMatter3.GetComponent<Text>().text = "" + 0;
        m_TextMatter3.transform.localPosition = 2*m_Offset + m_TextMatter1.transform.localPosition;

        m_TextMatter4 = Instantiate(m_TextMatter1);
        m_TextMatter4.transform.SetParent(this.transform);
        m_TextMatter4.transform.rotation = m_TextMatter1.transform.rotation;
        m_TextMatter4.transform.localScale = m_TextMatter1.transform.localScale;
        m_TextMatter4.GetComponent<Text>().text = "" + 0;
        m_TextMatter4.transform.localPosition = 3 * m_Offset + m_TextMatter1.transform.localPosition;

        m_TextMatter5 = Instantiate(m_TextMatter1);
        m_TextMatter5.transform.SetParent(this.transform);
        m_TextMatter5.transform.rotation = m_TextMatter1.transform.rotation;
        m_TextMatter5.transform.localScale = m_TextMatter1.transform.localScale;
        m_TextMatter5.GetComponent<Text>().text = "" + 0;
        m_TextMatter5.transform.localPosition = 4 * m_Offset + m_TextMatter1.transform.localPosition;

        m_TextMatter6 = Instantiate(m_TextMatter1);
        m_TextMatter6.transform.SetParent(this.transform);
        m_TextMatter6.transform.rotation = m_TextMatter1.transform.rotation;
        m_TextMatter6.transform.localScale = m_TextMatter1.transform.localScale;
        m_TextMatter6.GetComponent<Text>().text = "" + 0;
        m_TextMatter6.transform.localPosition = 5 * m_Offset + m_TextMatter1.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        switch(type)
        {
            case 1:matter1No++;type = 0;break;
            case 2:matter2No++;type = 0;break;
            case 3:matter3No++;type = 0;break;
            case 4: matter4No++; type = 0; break;
            case 5: matter5No++; type = 0; break;
            case 6: matter6No++; type = 0; break;

        }
        for(;m_Matter1<matter1No;m_Matter1++)
        {
            m_Copy=Instantiate(m_Matter1Count);
            
            m_Copy.transform.SetParent(this.transform);
            //m_Copy.transform.position = m_Inform.transform.position;
            m_Copy.transform.rotation = m_Matter1Count.transform.rotation;
            m_Copy.transform.localScale = m_Matter1Count.transform.localScale;

            m_Offset.x = 100;
            m_Offset.y = -50 + m_Matter1 * 3;
            m_Offset.z = 0;
            m_Copy.transform.localPosition = m_Offset;

            m_Copy.GetComponent<CanvasGroup>().alpha = 1;

            m_TextMatter1.GetComponent<Text>().text = ""+(m_Matter1 + 1);
            m_TextMatter1.transform.localPosition = m_Offset;
        }

        for (; m_Matter2 < matter2No; m_Matter2++)
        {
            m_Copy = Instantiate(m_Matter1Count);

            m_Copy.transform.SetParent(this.transform);
            m_Copy.GetComponent<Image>().color = Color.blue;
            m_Copy.transform.rotation = m_Matter1Count.transform.rotation;
            m_Copy.transform.localScale = m_Matter1Count.transform.localScale;

            m_Offset.x = 150;
            m_Offset.y = -50 + m_Matter2 * 3;
            m_Offset.z = 0;
            m_Copy.transform.localPosition = m_Offset;

            m_Copy.GetComponent<CanvasGroup>().alpha = 1;

           
            m_TextMatter2.GetComponent<Text>().text = "" + (m_Matter2 + 1);
            m_TextMatter2.transform.localPosition = m_Offset;
        }

        for (; m_Matter3 < matter3No; m_Matter3++)
        {
            m_Copy = Instantiate(m_Matter1Count);

            m_Copy.transform.SetParent(this.transform);
            m_Copy.GetComponent<Image>().color = Color.yellow;
            m_Copy.transform.rotation = m_Matter1Count.transform.rotation;
            m_Copy.transform.localScale = m_Matter1Count.transform.localScale;

            m_Offset.x = 200;
            m_Offset.y = -50 + m_Matter3 * 3;
            m_Offset.z = 0;
            m_Copy.transform.localPosition = m_Offset;

            m_Copy.GetComponent<CanvasGroup>().alpha = 1;


            m_TextMatter3.GetComponent<Text>().text = "" + (m_Matter3 + 1);
            m_TextMatter3.transform.localPosition = m_Offset;
        }

        for (; m_Matter4 < matter4No; m_Matter4++)
        {
            m_Copy = Instantiate(m_Matter1Count);

            m_Copy.transform.SetParent(this.transform);
            m_Copy.GetComponent<Image>().color = Color.green;
            m_Copy.transform.rotation = m_Matter1Count.transform.rotation;
            m_Copy.transform.localScale = m_Matter1Count.transform.localScale;

            m_Offset.x = 250;
            m_Offset.y = -50 + m_Matter4 * 3;
            m_Offset.z = 0;
            m_Copy.transform.localPosition = m_Offset;

            m_Copy.GetComponent<CanvasGroup>().alpha = 1;


            m_TextMatter4.GetComponent<Text>().text = "" + (m_Matter4 + 1);
            m_TextMatter4.transform.localPosition = m_Offset;
        }

        for (; m_Matter5 < matter5No; m_Matter5++)
        {
            m_Copy = Instantiate(m_Matter1Count);

            m_Copy.transform.SetParent(this.transform);
            m_Copy.GetComponent<Image>().color = Color.grey;
            m_Copy.transform.rotation = m_Matter1Count.transform.rotation;
            m_Copy.transform.localScale = m_Matter1Count.transform.localScale;

            m_Offset.x = 300;
            m_Offset.y = -50 + m_Matter5 * 3;
            m_Offset.z = 0;
            m_Copy.transform.localPosition = m_Offset;

            m_Copy.GetComponent<CanvasGroup>().alpha = 1;


            m_TextMatter5.GetComponent<Text>().text = "" + (m_Matter5 + 1);
            m_TextMatter5.transform.localPosition = m_Offset;
        }

        for (; m_Matter6 < matter6No; m_Matter6++)
        {
            m_Copy = Instantiate(m_Matter1Count);

            m_Copy.transform.SetParent(this.transform);
            m_Copy.GetComponent<Image>().color = Color.white;
            m_Copy.transform.rotation = m_Matter1Count.transform.rotation;
            m_Copy.transform.localScale = m_Matter1Count.transform.localScale;

            m_Offset.x = 350;
            m_Offset.y = -50 + m_Matter6 * 3;
            m_Offset.z = 0;
            m_Copy.transform.localPosition = m_Offset;

            m_Copy.GetComponent<CanvasGroup>().alpha = 1;


            m_TextMatter6.GetComponent<Text>().text = "" + (m_Matter6 + 1);
            m_TextMatter6.transform.localPosition = m_Offset;
        }


    }
}
