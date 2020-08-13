using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Click()
    {
        this.transform.parent.gameObject.GetComponent<CanvasGroup>().alpha = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
