using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("TitleScene");
        }

    }
}
