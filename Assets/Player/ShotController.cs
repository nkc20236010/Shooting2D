using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    GameObject gameDir;

    void Start()
    {
        Destroy(gameObject,1.5f);  //1.5�b��������Shot��������

        gameDir = GameObject.Find("GameDirector");
    }

    void Update()
    {
        transform.Translate(0, 0.08f, 0);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "EnemyTag")
        {
            gameDir.GetComponent<GameDirector>().KillCounter();
            GameDirector.score += 200;
            Destroy(gameObject);
        }
    }
}
