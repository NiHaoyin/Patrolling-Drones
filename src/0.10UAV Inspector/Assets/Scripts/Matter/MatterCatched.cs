using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatterCatched : MonoBehaviour
{
    

    public float viewPointX;
    public float viewPointY;
    public float viewPointZ;

    public string send = "On";
    public int mark;

    public GameObject fly;
    public GameObject flyCam;

    public int No;

   
    private GameObject m_NumberOfMatter;
    private GameObject m_Shelf;

    

    


    // Start is called before the first frame update

    void Start()
    {
        if (this.GetComponent<property>().shelf <= 4)
        {
            fly = GameObject.Find("Fly");
            flyCam = GameObject.Find("FlyCamera");
        }
        else
        {
            fly = GameObject.Find("Fly2");
            flyCam = GameObject.Find("FlyCamera2");
        }
        
        m_NumberOfMatter = GameObject.Find("Matter"+ this.GetComponent<property>().type);
        m_Shelf = GameObject.Find("Shelf" + this.GetComponent<property>().shelf);
        


    }

    // Update is called once per frame
    void Update()
    {


        viewPointX = flyCam.GetComponent<Camera>().WorldToViewportPoint(this.transform.position).x;
        viewPointY = flyCam.GetComponent<Camera>().WorldToViewportPoint(this.transform.position).y;
        viewPointZ = flyCam.GetComponent<Camera>().WorldToViewportPoint(this.transform.position).z;
        if (mark == 1 & fly.GetComponent<FlyCatch>().mark==1)
        {
            send = "On";
            mark = 0;
        }

        if (viewPointX > 0 & viewPointX < 1 & viewPointY > 0 & viewPointY < 1 & viewPointZ > 0 & viewPointZ < 15 & send=="On" & fly.GetComponent<FlyCatch>().isEmpty)
        {
            fly.GetComponent<FlyCatch>().isEmpty = false;
            fly.GetComponent<FlyCatch>().number ++;
            No = fly.GetComponent<FlyCatch>().number;///给物体编号

            int n= m_NumberOfMatter.GetComponentInChildren<MatterNumber>().number++;
            m_NumberOfMatter.GetComponentInChildren<MatterNumber>().numberArray[n] = No;
            m_NumberOfMatter.GetComponentInChildren<MatterNumber>().typeArray[n] = this.GetComponent<property>().type;
            m_NumberOfMatter.GetComponentInChildren<MatterNumber>().shelfArray[n] = this.GetComponent<property>().shelf;
            m_NumberOfMatter.GetComponentInChildren<MatterNumber>().boardArray[n] = this.GetComponent<property>().board;
            m_NumberOfMatter.GetComponentInChildren<MatterNumber>().locationArray[n] = this.GetComponent<property>().No;///将信息传递给类别统计

            m_Shelf.GetComponent<Counting>().type = this.GetComponent<property>().type;


            
            send = "Off";
            this.transform.Find("box").GetComponent<MeshRenderer>().material.color = Color.green;
            this.transform.Find("Face").GetComponent<MeshRenderer>().material.color = Color.green;

        }
        
    }

    private void LateUpdate()
    {
        fly.GetComponent<FlyCatch>().isEmpty = true;
    }


}
