using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatterNumber : MonoBehaviour
{
    public int number;
    public int[] numberArray = new int[100];
    public int[] typeArray = new int[100];
    public int[] shelfArray = new int[100];
    public int[] boardArray = new int[100];
    public string[] locationArray = new string[100];

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = "已统计数量：" + number;
       
        
    }
}
