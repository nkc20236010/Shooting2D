using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 0.9f;
    float delta = 0;


    void Start()
    {

    }

    void Update()
    {
        //�G�𐶐�����
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            int ex = Random.Range(-8,9);
            go.transform.position = new Vector3(ex, 5.7f, 0);
        }
    }
}


