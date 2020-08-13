using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCameraInformation : MonoBehaviour
{
    private GameObject m_Inform;
    private GameObject m_Name;
    private GameObject m_Director;
    private GameObject m_MonitorDirector;
    private GameObject m_FlyInform;
    

    public bool isNotExist = true;
    // Start is called before the first frame update
    void Start()
    {
        m_Inform = GameObject.Find("CameraInform");
        this.GetComponent<Camera>().enabled = false;
        m_Name = m_Inform.transform.Find("Text_CameraName").gameObject;
        m_Director = m_Inform.transform.Find("Text_MoveDirector").gameObject;
        m_MonitorDirector= m_Inform.transform.Find("Text_MoveMonitor").gameObject;
        m_FlyInform = m_Inform.transform.Find("Text_FlyInformation").gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<Camera>().enabled & isNotExist)
        {
            
                m_Inform.GetComponent<CanvasGroup>().alpha = 1;
                m_Director.GetComponent<CanvasGroup>().alpha = 0;
            if (this.transform.name == "FlyCamera")
            {
                m_Name.GetComponent<UnityEngine.UI.Text>().text = "无人机1号主视角";
                m_FlyInform.GetComponent<CanvasGroup>().alpha = 1;
                m_MonitorDirector.GetComponent<CanvasGroup>().alpha = 0;
            }
            if (this.transform.name == "FlyCamera2")
            {
                m_Name.GetComponent<UnityEngine.UI.Text>().text = "无人机2号主视角";
                m_FlyInform.GetComponent<CanvasGroup>().alpha = 1;
                m_MonitorDirector.GetComponent<CanvasGroup>().alpha = 0;

            }
            if (this.transform.name == "Monitor")
            {
                m_Name.GetComponent<UnityEngine.UI.Text>().text = "无人机1号第三人称视角";
                m_MonitorDirector.GetComponent<CanvasGroup>().alpha = 1;
                m_FlyInform.GetComponent<CanvasGroup>().alpha = 0;
            }
            if (this.transform.name == "Monitor2")
            {
                m_Name.GetComponent<UnityEngine.UI.Text>().text = "无人机2号第三人称视角";
                m_MonitorDirector.GetComponent<CanvasGroup>().alpha = 1;
                m_FlyInform.GetComponent<CanvasGroup>().alpha = 0;
            }
        }
                
           
            isNotExist = false;
        }
    }

