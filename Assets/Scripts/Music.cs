using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource BackGroungMusic;
   public static bool muze;
     void Start()
     {
         if (muze == false)
         {
             GetComponent<AudioSource>().Play();
             muze = true;
         }
         else { GetComponent<AudioSource>().Stop(); }
     }
     void Awake()
     {
         DontDestroyOnLoad(transform.gameObject);
     }
     void Update()
     {
         if (!GetComponent<AudioSource>().isPlaying) {
             GetComponent<AudioSource>().Play();
          
          
         }
          
     }
}
