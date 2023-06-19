using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUP : MonoBehaviour
{

    
    void Start()
    {
        Destroy(gameObject, 3f);  //3�b��ɏ�����
    }

    void Update()
    {
        transform.Translate(0, -0.02f, 0);  //Item�̏c�ړ�
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
