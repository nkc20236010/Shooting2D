using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{

    GameObject gameDirector;

    void Start()
    {
        gameDirector = GameObject.Find("GameDirector");
        Destroy(gameObject,2f);
    }

    void Update()
    {
        transform.Translate(0, 0.06f, 0);
    }

}