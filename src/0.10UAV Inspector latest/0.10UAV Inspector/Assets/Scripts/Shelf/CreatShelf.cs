using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatShelf : MonoBehaviour
{
    public GameObject shelfPrefab;
    private Vector3 m_Position;
    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject newMatter = Instantiate(shelfPrefab);
            m_Position.x = 10;
            m_Position.y = 0;
            m_Position.z = 10 + 2 * i;
            newMatter.transform.name = "Shelf+" + i;
            newMatter.transform.SetParent(this.transform);
            newMatter.transform.rotation = shelfPrefab.transform.rotation;
            newMatter.transform.localPosition = m_Position;//shelfPrefab.transform.position+m_Position;
        }

        for (int i = 0; i < 4; i++)
        {
            GameObject newMatter = Instantiate(shelfPrefab);
            m_Position.x = 8;
            m_Position.y = 0;
            m_Position.z = 10 + 2 * i;
            newMatter.transform.name = "Shelf+" + (i+4);
            newMatter.transform.SetParent(this.transform);
            newMatter.transform.rotation = shelfPrefab.transform.rotation;
            newMatter.transform.localPosition = m_Position;//shelfPrefab.transform.position+m_Position;
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
