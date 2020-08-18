using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class property : MonoBehaviour
{
    public string locationName;
    public string typeName;
    public string boardName;
    public string shelfName;
    public string fly;
    public string flyName;
    


    public int type;
    public int shelf;
    public int board;
    public string No;
    
    private void Awake()
    {
      
   
}
    


    // Start is called before the first frame update
    void Start()
    {
        switch(type)
        {
            case 1:typeName = "内存DDR8GB";break;
            case 2:typeName = "内存DDR16GB";break;
            case 3:typeName = "内存DDR32GB";break;
            case 4:typeName = "硬盘HDD1TB";break;
            case 5:typeName = "硬盘SSD256GB";break;
            case 6:typeName = "硬盘SSD512GB";break;
        }
        switch (shelf)
        {
            case 1: shelfName = "第一货架"; break;
            case 2: shelfName = "第二货架"; break;
            case 3: shelfName = "第三货架"; break;
            case 4: shelfName = "第四货架"; break;
            case 5: shelfName = "第五货架"; break;
            case 6: shelfName = "第六货架"; break;
            case 7: shelfName = "第七货架"; break;
            case 8: shelfName = "第八货架"; break;

        }
        switch (board)
        {
            case 1: boardName = "第一层"; break;
            case 2: boardName = "第二层"; break;
            case 3: boardName = "第三层"; break;
            case 4: boardName = "第四层"; break;
            
        }
        switch (No)
        {
            case "L1": locationName = "前侧第一个"; break;
            case "L2": locationName = "前侧第二个"; break;
            case "L3": locationName = "前侧第三个"; break;
            case "L4": locationName = "前侧第四个"; break;
            case "R1": locationName = "后侧第一个"; break;
            case "R2": locationName = "后侧第二个"; break;
            case "R3": locationName = "后侧第三个"; break;
            case "R4": locationName = "后侧第四个"; break;

        }
        if(shelf<=4)
        {
            fly = "F";
            flyName = "一号飞机";
        }
        else
        {
            fly = "FF";
            flyName = "二号飞机";

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
