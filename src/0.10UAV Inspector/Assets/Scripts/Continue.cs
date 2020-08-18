using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Continue : MonoBehaviour
{
    private GameObject m_Fly;
    private GameObject m_Fly2;

    // Start is called before the first frame update
    void Start()
    {
        m_Fly = GameObject.Find("Fly");
        m_Fly2 = GameObject.Find("Fly2");
    }

    // Update is called once per frame
    public void Click()
    {
        
        m_Fly.GetComponent<FlyCatch>().isStart = true;
        this.GetComponent<CanvasGroup>().alpha = 0;
    }
    public void Click2()
    {
        m_Fly2.GetComponent<FlyCatch>().isStart = true;
        this.GetComponent<CanvasGroup>().alpha = 0;
    }
    void Update()
    {
        
    }
}
