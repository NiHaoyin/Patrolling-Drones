using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeWindow : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        this.GetComponent<Drag>().enabled = false;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
