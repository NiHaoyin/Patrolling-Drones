using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    private void Awake()
    {
        this.GetComponent<Camera>().enabled= false;
    }
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
        }
    }
}
