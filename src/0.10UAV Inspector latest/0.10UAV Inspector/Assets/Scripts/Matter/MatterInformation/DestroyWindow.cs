using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyWindow : MonoBehaviour
{
    private GameObject m_Window;
    


    // Start is called before the first frame update
    void Start()
    {
        m_Window = this.transform.parent.gameObject;
       
        
        
        

}

    // Update is called once per frame
    private void Update()
    {
        
    }
    public void ClickIt()
    {
        Destroy(m_Window);
        
    
}
}
