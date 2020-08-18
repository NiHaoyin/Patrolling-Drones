using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeToFly : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject flyCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("MainCamera");
        flyCamera = GameObject.Find("FlyCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        flyCamera.GetComponent<Camera>().enabled = true;
        mainCamera.GetComponent<Camera>().enabled = false;
        flyCamera.GetComponent<FlyCameraInformation>().isNotExist = true;
    }
}
