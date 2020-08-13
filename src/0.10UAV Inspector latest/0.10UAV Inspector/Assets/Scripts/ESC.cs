using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ESC : MonoBehaviour
{
   /// public GameObject inform;
    // Start is called before the first frame update
    void Start()
    {
        ///inform = GameObject.Find("MatterInformation");
    }
    public void Click()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        ///transform.SetSiblingIndex(inform.GetComponent<Drag>().siblingIndex - 2);
    }
}
