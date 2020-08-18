using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{ 
    private Vector3 m_Offset;
public int siblingIndex = 0;
    public bool isGo = true;
public void OnDrag(PointerEventData eventData)
{if(isGo)
        { transform.position = Input.mousePosition + m_Offset; }
    
}
public void OnPointerDown(PointerEventData eventData)
{if (isGo)
        {
            m_Offset = transform.position - Input.mousePosition;
            transform.SetSiblingIndex(siblingIndex - 1);
        }
}
public void OnPointerUp(PointerEventData eventData)
{

}  

}
