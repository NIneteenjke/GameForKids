using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoy_second_buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button1;
    public GameObject button2;
    bool isClicked;
    public int sum;
    public int all_summa;
    public int indexButton;
    public void onClick()
   {
       isClicked = true;
   }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sum=PlayerPrefs.GetInt("sum");
        

        if(isClicked)
       {
           indexButton=1;
           
       }
        all_summa=sum+indexButton;
        Debug.Log(all_summa+"all");
        if(all_summa==2)
       {
       Destroy (button1);
       Destroy (button2);
       }
    }
}
