using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatMatter : MonoBehaviour
{
    public GameObject matterPrefab;
    public GameObject matter2Prefab;
    private Vector3 m_Offset;
    public int type;
    public int number;

    public int board;
    public int shelf;

    public float hight;
    
    
    private void Awake()
    {
        shelf = this.transform.parent.transform.parent.GetComponent<InitializeShelf>().shelf;
        for (int i = 0; i < 4; i++)
        { GameObject newMatter = Instantiate(matterPrefab);
            m_Offset.x = (float)(-0.5+0.3*i);
            m_Offset.y = hight;
            m_Offset.z = (float)(0.5);
            newMatter.transform.name = "Matter+"+i;
            newMatter.transform.SetParent(this.transform);
            newMatter.transform.rotation = matterPrefab.transform.rotation;
            newMatter.transform.localPosition = m_Offset;//matterPrefab.transform.position+m_Offset;
            
            newMatter.GetComponent<property>().type = type;
            newMatter.GetComponent<property>().shelf = shelf;
            newMatter.GetComponent<property>().board = board;
            newMatter.GetComponent<property>().No = "L" + (i+1);

            if (number != 0 & i >= number)
            { newMatter.GetComponent<property>().type = type+1; }




        }
        for (int j = 0; j < 4; j++)
        {
            
            GameObject newMatter = Instantiate(matter2Prefab);
            m_Offset.x = (float)(-0.5 + 0.3 * j);
            m_Offset.y = hight;
            m_Offset.z = (float)(-0.6);
            newMatter.transform.name = "Matter+" + j+4;
            newMatter.transform.SetParent(this.transform);
            newMatter.transform.rotation = matter2Prefab.transform.rotation;
            newMatter.transform.localPosition = m_Offset;//matterPrefab.transform.position+m_Offset;
            newMatter.GetComponent<MatterCatched>().send = "Off";
            newMatter.GetComponent<MatterCatched>().mark = 1;

            newMatter.GetComponent<property>().type = type;
            newMatter.GetComponent<property>().shelf = shelf;
            newMatter.GetComponent<property>().board = board;
            newMatter.GetComponent<property>().No = "R" + (j+1);

            if (number != 0 & j +4>=number)
            {
                newMatter.GetComponent<property>().type = type + 1;
            }

        }





    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
