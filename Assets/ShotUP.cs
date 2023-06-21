using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotUP : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerTag")
        {
            PlayerController.power += 1;
            Destroy(gameObject);
        }
    }

}
