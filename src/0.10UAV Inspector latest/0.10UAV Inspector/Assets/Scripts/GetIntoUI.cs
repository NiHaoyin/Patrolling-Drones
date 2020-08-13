using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetIntoUI : MonoBehaviour
{
    private GameObject m_UI;
    private GameObject m_Fly;
    // Start is called before the first frame update
    void Start()
    {
        m_UI = GameObject.Find ( "UI" );
        
    }

    // Update is called once per frame
    public void Click()
    {
        m_UI.GetComponent<CanvasGroup>().alpha = 1;
        

    }
    void Update()
    {
        
    }
}
