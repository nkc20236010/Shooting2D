using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 0.8f;
    float delta = 0;


    void Start()
    {

    }

    void Update()
    {
        //敵を生成する
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            int ex = Random.Range(-3, 4);
            go.transform.position = new Vector3(10, ex, 0);
        }
    }
}


