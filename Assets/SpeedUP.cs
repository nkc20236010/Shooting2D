using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUP : MonoBehaviour
{

    
    void Start()
    {
        Destroy(gameObject, 3f);  //3秒後に消える
    }

    void Update()
    {
        transform.Translate(0, -0.02f, 0);  //Itemの縦移動
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerTag")
        {
            PlayerController.speed += 0.01f;
            Destroy(gameObject);
        }
    }
}
