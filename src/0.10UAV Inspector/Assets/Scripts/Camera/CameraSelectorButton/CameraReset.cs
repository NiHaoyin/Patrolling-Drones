using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour
{
    private Vector3 m_initialPosition;
    private Quaternion m_initialRotation;
    public GameObject mainCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.Find("MainCamera");
        m_initialPosition = mainCam.transform.position;
        m_initialRotation = mainCam.transform.rotation;
    }
    public void Click()
    {
        mainCam.transform.position = m_initialPosition;
        mainCam.transform.rotation = m_initialRotation;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
