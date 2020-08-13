using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToChart : MonoBehaviour
{
    private GameObject m_ChartCanvas;
    // Start is called before the first frame update
    void Start()
    {
        m_ChartCanvas = GameObject.Find("ChartCanvas");
    }
    public void Click()
    {
        this.transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
        m_ChartCanvas.GetComponent<Canvas>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
