using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Change_image : MonoBehaviour
{
    public Sprite Picture1;
    public Sprite Picture2;
 
    private Image im;
    void Start()
    {
        im = GetComponent <Image>();
        im.sprite = Picture1;
    } 
        public void Change()
    {
        if (im.sprite == Picture1)
        {
            im.sprite = Picture2;
            return;
        }
 
        if (im.sprite == Picture2)
        {
            im.sprite = Picture1;
            return;
        }
    }   

}
