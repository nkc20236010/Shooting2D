using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class KmScoer : MonoBehaviour
{
    public static float Km;
    
    void Start()
    {
        GetComponent<Text>().text = Km.ToString("000000") + "Km";
    }

    void Update()
    {
        
    }
}
