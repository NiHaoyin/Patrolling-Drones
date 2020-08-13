using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeToMain : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject flyCamera;
    public GameObject flyCamera2;
    public GameObject monitor1;
    public GameObject monitor2;
    private GameObject[] m_CameraArray = new GameObject[5];

    
    // Start is called before the first frame update
    void Start()
    {
        m_CameraArray[0] = GameObject.Find("MainCamera");
        m_CameraArray[1] = GameObject.Find("FlyCamera");
        m_CameraArray[2] = GameObject.Find("FlyCamera2");
        m_CameraArray[3] = GameObject.Find("Monitor");
        m_CameraArray[4] = GameObject.Find("Monitor2");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void Click1()
{
        for(int i=0;i<5;i++)
        {
            if(i==0)
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = true;
                m_CameraArray[i].GetComponent<CameraInformation>().isNotExist = true;

            }
            else
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = false;
            }
            }
    }


    public void Click2()
    {
        for (int i = 0; i <5; i++)
        {
            if (i == 1)
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = true;
                m_CameraArray[i].GetComponent<FlyCameraInformation>().isNotExist = true;

            }
            else
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = false;
            }
        }
    }


    public void Click3()
    {
        for (int i = 0; i <5; i++)
        {
            if (i == 2)
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = true;
                m_CameraArray[i].GetComponent<FlyCameraInformation>().isNotExist = true;

            }
            else
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = false;
            }
        }
    }


    public void Click4()
    {
        for (int i = 0; i <5; i++)
        {
            if (i == 3)
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = true;
                m_CameraArray[i].GetComponent<FlyCameraInformation>().isNotExist = true;

            }
            else
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = false;
            }
        }
    }


    public void Click5()
    {
        for (int i = 0; i <5; i++)
        {
            if (i == 4)
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = true;
                m_CameraArray[i].GetComponent<FlyCameraInformation>().isNotExist = true;

            }
            else
            {
                m_CameraArray[i].GetComponent<Camera>().enabled = false;
            }
        }
    }








}
