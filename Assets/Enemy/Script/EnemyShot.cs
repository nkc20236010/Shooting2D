using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] float speed;

    GameObject gameDirector;

    void Start()
    {
        gameDirector = GameObject.Find("GameDirector");
        Destroy(gameObject,2f);
    }

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

}