using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private bool m_Click=false;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<Camera>().enabled)
        {
            if (Input.GetKey(KeyCode.Q))
            {
               transform.Rotate(0, -25 * Time.deltaTime, 0, Space.Self);
           }
           if (Input.GetKey(KeyCode.E))
          {
               transform.Rotate(0, 25 * Time.deltaTime, 0, Space.Self);
            }
          if (Input.GetKey(KeyCode.N))
            {
             transform.Rotate(-25 * Time.deltaTime, 0, 0, Space.Self);
           }
          if (Input.GetKey(KeyCode.H))
        {
               transform.Rotate(25 * Time.deltaTime, 0, 0, Space.Self);
          }
            if (Input.GetKey(KeyCode.R))
            {
                transform.Translate(0, 3 * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.F))
            {
                transform.Translate(0, -3 * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, 3 * Time.deltaTime);

            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, -3 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-3 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(3 * Time.deltaTime, 0, 0);
            }
            if(Input.GetMouseButtonDown(1))
            {
                m_Click = true;
            }
            if (Input.GetMouseButtonUp(1))
            {
                m_Click = false;
            }
            if(m_Click)
            {
                float mouseX = Input.GetAxis("Mouse X");
                float mouseY = Input.GetAxis("Mouse Y");
                this.transform.Rotate(Vector3.up, -mouseX * 0.7f, Space.World);
                this.transform.Rotate(Vector3.right, mouseY * 0.7f, Space.Self);
            }


        }


    }
}
