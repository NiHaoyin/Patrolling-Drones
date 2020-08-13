using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWindowForCam : MonoBehaviour
{
    private GameObject m_Window;
    // Start is called before the first frame update
    void Start()
    {
        m_Window = this.transform.parent.gameObject;
    }

    public void ClickIt()
    {
        m_Window.GetComponent<CanvasGroup>().alpha = 0;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
