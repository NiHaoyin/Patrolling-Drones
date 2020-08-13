using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matter1Detail : MonoBehaviour
{
    private GameObject m_DetailedCanvas;
    public int type;
    
    // Start is called before the first frame update
    void Start()
    {
        m_DetailedCanvas = GameObject.Find("DetailedCanvas");
    }
    public void Click()
    {
        this.transform.parent.gameObject.transform.parent.GetComponent<Canvas>().enabled = false;
        m_DetailedCanvas.GetComponent<Canvas>().enabled = true;
        m_DetailedCanvas.GetComponent<DetailedData>().type = type;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
