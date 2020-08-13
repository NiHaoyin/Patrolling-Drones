using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMain : MonoBehaviour
{
    private GameObject m_MainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        m_MainCanvas = GameObject.Find("Canvas");
    }

    public void Click()
    {
        this.transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
        m_MainCanvas.GetComponent<Canvas>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
