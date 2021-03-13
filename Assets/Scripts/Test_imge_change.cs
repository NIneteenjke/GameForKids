using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class Test_imge_change : MonoBehaviour
{

   private bool CompareTexture (Texture2D first, Texture2D second)
{
    Color[] firstPix = first.GetPixels();
    Color[] secondPix = second.GetPixels();
    if (firstPix.Length!= secondPix.Length)
    {
        return false;
        Debug.Log("Тест1");
    }
    for (int i= 0;i < firstPix.Length;i++)
    {
        if (firstPix[i] != secondPix[i])
        {
            return false;
            Debug.Log("Тест2");
        }
    }

    return true;
     
    Debug.Log("Тест3");
    }
}
