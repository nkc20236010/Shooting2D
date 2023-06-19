using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotUP : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.Translate(0, -0.02f, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerTag")
        {
            PlayerController.power += 1;
            Destroy(gameObject);
        }
    }

}
