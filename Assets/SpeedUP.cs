using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUP : MonoBehaviour
{
    [SerializeField] float speed;
    
    void Start()
    {
        Destroy(gameObject, 5f);  //3ïbå„Ç…è¡Ç¶ÇÈ
    }

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
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
