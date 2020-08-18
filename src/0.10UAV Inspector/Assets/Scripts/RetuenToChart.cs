using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetuenToChart : MonoBehaviour
{
    private GameObject m_ChartCanvas;
    private GameObject m_Destroy;
    // Start is called before the first frame update
    void Start()
    {
        m_ChartCanvas = GameObject.Find("ChartCanvas");
        m_Destroy = GameObject.Find("ForDestroy");
    }
    public void Click()
    {
        for (int i = 0; i < m_Destroy.transform.childCount; i++)
        {
            Destroy(m_Destroy.transform.GetChild(i).gameObject);
            
        }
        this.transform.parent.gameObject.GetComponent<DetailedData>().countingNumber = 0;
        this.transform.parent.gameObject.GetComponent<DetailedData>().type = 0;


        this.transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
        m_ChartCanvas.GetComponent<Canvas>().enabled = true;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
