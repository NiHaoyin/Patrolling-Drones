using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfSelector : MonoBehaviour
{
    private GameObject[] m_Shelf = new GameObject[8];

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<8;i++)
        {
            m_Shelf[i] = GameObject.Find("Shelf" + (i + 1));
        }
    }
    public void DropdownSelect(int n)
    {for(int i=0;i<8;i++ )
        {
            if(i==n)
            {
                m_Shelf[i].GetComponent<CanvasGroup>().alpha = 1;
            }
            else
            {
                m_Shelf[i].GetComponent<CanvasGroup>().alpha = 0;
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
