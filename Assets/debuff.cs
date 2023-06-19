using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debuff : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }

    void Update()
    {
        transform.Translate(0, -0.02f, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "PlayerTag")
        {
            PlayerController.speed -= 0.01f;
            PlayerController.power -= 1;
            Destroy(gameObject);
        }
    }
}
