using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;


public class FlyCatch : MonoBehaviour
{
    // Start is called before the first frame update

    
    
    public int number;
    public bool isStart=false;
    public bool isEmpty = true;
    public bool isFly = false;
    private float m_x;
    private UnityEngine.Vector3 m_Offset;
    
    public int mark;
    public int i;

    private string[] xArray = new string[10000];
    private string[] yArray = new string[10000];
    private string[] zArray = new string[10000];
    private string[] rArray = new string[10000];

    public UnityEngine.Vector3 offset;
    public float rot;


    public string pathx;
    public string pathy;
    public string pathz;
    public string pathr;



    void Start()
    {
        if (this.transform.name == "Fly")
        {
            pathx = Application.streamingAssetsPath+@"/px.txt";
            pathy = Application.streamingAssetsPath+@"/py.txt";
            pathz = Application.streamingAssetsPath+@"/pz.txt";
            pathr= Application.streamingAssetsPath+@"/pr.txt";
        }
        else
        {
            pathx = Application.streamingAssetsPath+@"/px2.txt";
            pathy = Application.streamingAssetsPath+@"/py2.txt";
            pathz = Application.streamingAssetsPath+@"/pz2.txt";
            pathr = Application.streamingAssetsPath + @"/pr2.txt";
            
        }

        xArray = File.ReadAllLines(pathx);
        yArray = File.ReadAllLines(pathy);
        zArray = File.ReadAllLines(pathz);
        rArray = File.ReadAllLines(pathr);


    }
 


    // Update is called once per 
    void Update()
    {
        //File.WriteAllText(Application.streamingAssetsPath + @"/myoutput.txt", str);
        if(isStart)
        {
            if ((i+1)<=xArray.Length)
            {
                offset.x = float.Parse(xArray[i]);
                offset.y = float.Parse(yArray[i]);
                offset.z = float.Parse(zArray[i]);


                if ((i + 2) <= xArray.Length)
                {
                    this.transform.Rotate(0, float.Parse(rArray[i + 1]) - float.Parse(rArray[i]), 0);
                }
                this.transform.position = offset;
                i = i + 1;
            }
            
            else
            {
                isStart = false;
            }




            if (float.Parse(rArray[i] )> 175f)
            {
                mark = 1;
            }
               


           


            

            

        }
        


    }
}
