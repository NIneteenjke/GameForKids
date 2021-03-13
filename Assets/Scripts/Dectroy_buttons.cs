using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dectroy_buttons : MonoBehaviour
{
    public static int summa;
    
    bool isClicked;
    int sum;
    int indexButton=0;
   public void onClick()
   {
       isClicked = true;
   }
   void Update()
   {
       if(isClicked)
       {
           indexButton=1;
           
       }
       if(PlayerPrefs.HasKey("sum"))
       {
           PlayerPrefs.SetInt("sum",indexButton);
           PlayerPrefs.Save();
           Debug.Log(indexButton+"Первый скрипт");
       }
       
    
   }
}
