using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyInformLeft : MonoBehaviour
{
    private GameObject m_FlyX;
    private GameObject m_FlyY;
    private GameObject m_FlyZ;
    private GameObject m_Fly;
    private GameObject m_Fly1;
    private GameObject m_Fly2;

    // Start is called before the first frame update
    void Start()
    {
        m_FlyX = this.transform.Find("Text_PosX").gameObject;
        m_FlyY = this.transform.Find("Text_PosY").gameObject;
        m_FlyZ = this.transform.Find("Text_PosZ").gameObject;
        m_Fly1 = GameObject.Find("Fly");
        m_Fly2 = GameObject.Find("Fly2");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.parent.transform.name == "CameraInformLeft")
        {
            m_Fly = m_Fly2;
        }
        else
        {
            m_Fly = m_Fly1;
        }
        m_FlyX.GetComponent<UnityEngine.UI.Text>().text = "PosX：" + m_Fly.transform.position.x;
        m_FlyY.GetComponent<UnityEngine.UI.Text>().text = "PosY：" + m_Fly.transform.position.y;
        m_FlyZ.GetComponent<UnityEngine.UI.Text>().text = "PosZ：" + m_Fly.transform.position.z;

       

    }
}
