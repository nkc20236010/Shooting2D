using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debuff : MonoBehaviour
{
    [SerializeField] float speed;
    
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerTag")
        {
            PlayerController.speed -= 0.01f;
            PlayerController.power -= 1;
            Destroy(gameObject);
        }
    }
}
