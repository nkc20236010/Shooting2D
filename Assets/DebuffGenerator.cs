using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffGenerator : MonoBehaviour
{
    public GameObject debuffPre;

    float span = 4f;
    float delta;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            int it = Random.Range(-10, 11);
            GameObject de = Instantiate(debuffPre);
            de.transform.position = new Vector3(it, 5.7f, 0);
            delta = 0;
        }
    }
}
