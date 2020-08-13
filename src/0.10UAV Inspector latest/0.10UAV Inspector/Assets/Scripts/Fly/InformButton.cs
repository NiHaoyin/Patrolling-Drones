using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformButton : MonoBehaviour
{
    private GameObject m_Window;
    
    // Start is called before the first frame update
    void Start()
    {
        if(this.name=="InformButton1")
        {
            m_Window = GameObject.Find("CameraInformLeft");
        }
        else
        {
            m_Window = GameObject.Find("CameraInformLeft2");
        }
           
        
    }
    public void Click()
    {
        m_Window.GetComponent<CanvasGroup>().alpha = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Window.GetComponent<CanvasGroup>().alpha == 1)
        {
            this.GetComponent<CanvasGroup>().alpha = 0;
        }
        else
        {
            this.GetComponent<CanvasGroup>().alpha = 1;
        }
    }
}
