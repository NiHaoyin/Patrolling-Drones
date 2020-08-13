using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyInformationUpdate : MonoBehaviour
{
    private GameObject m_FlyX;
    private GameObject m_FlyY;
    private GameObject m_FlyZ;
    private GameObject m_Fly;
    private GameObject m_Fly1;
    private GameObject m_Fly2;
    private GameObject m_CameraName;
    // Start is called before the first frame update
    void Start()
    {
        m_FlyX = this.transform.Find("Text_PosX").gameObject;
        m_FlyY = this.transform.Find("Text_PosY").gameObject;
        m_FlyZ = this.transform.Find("Text_PosZ").gameObject;
        m_Fly1 = GameObject.Find("Fly");
        m_Fly2 = GameObject.Find("Fly2");
        m_CameraName = GameObject.Find("Text_CameraName");

    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<CanvasGroup>().alpha == 1)
        {
            if(m_CameraName.GetComponent<Text>().text== "无人机2号主视角")
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

            if (!m_Fly.GetComponent<FlyCatch>().isFly)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "起飞中";

            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t < 4.2 / m_Fly.GetComponent<FlyCatch>().speedY + 2)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "位置：第一货架前侧";
            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t < 7.35 / m_Fly.GetComponent<FlyCatch>().speedY + 4 & m_Fly.GetComponent<FlyCatch>().t >= 4.2 / m_Fly.GetComponent<FlyCatch>().speedY + 2)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "位置：第二货架前侧";
            }

            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t >= 7.35 / m_Fly.GetComponent<FlyCatch>().speedY + 4 & m_Fly.GetComponent<FlyCatch>().t < 10.5 / m_Fly.GetComponent<FlyCatch>().speedY + 6)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "位置：第三货架前侧";
            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t < 13.65 / m_Fly.GetComponent<FlyCatch>().speedY + 7.5 & m_Fly.GetComponent<FlyCatch>().t >= 10.5 / m_Fly.GetComponent<FlyCatch>().speedY + 6)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "位置：第四货架前侧";
            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t >= 13.65 / m_Fly.GetComponent<FlyCatch>().speedY + 7.5 & m_Fly.GetComponent<FlyCatch>().t < 17.15 / m_Fly.GetComponent<FlyCatch>().speedY + 8)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "转向中";
            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t < 20.5 / m_Fly.GetComponent<FlyCatch>().speedY + 9.5 & m_Fly.GetComponent<FlyCatch>().t >= 17.15 / m_Fly.GetComponent<FlyCatch>().speedY + 8)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "位置：第一货架后侧";
            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t >= 20.5 / m_Fly.GetComponent<FlyCatch>().speedY + 9.5 & m_Fly.GetComponent<FlyCatch>().t < 23.65 / m_Fly.GetComponent<FlyCatch>().speedY + 12)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "位置：第二货架后侧";
            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t < 26.8 / m_Fly.GetComponent<FlyCatch>().speedY + 14 & m_Fly.GetComponent<FlyCatch>().t >= 23.65 / m_Fly.GetComponent<FlyCatch>().speedY + 12)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "位置：第三货架后侧";
            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t >= 26.8 / m_Fly.GetComponent<FlyCatch>().speedY + 14 & m_Fly.GetComponent<FlyCatch>().t < 30.15 / m_Fly.GetComponent<FlyCatch>().speedY + 16)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "位置：第四货架后侧";
            }
            if (m_Fly.GetComponent<FlyCatch>().isFly & m_Fly.GetComponent<FlyCatch>().t >= 26.8 / m_Fly.GetComponent<FlyCatch>().speedY + 14 & m_Fly.GetComponent<FlyCatch>().t >= 30.15 / m_Fly.GetComponent<FlyCatch>().speedY + 16)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "降落中";
            }
        }
    }
}
