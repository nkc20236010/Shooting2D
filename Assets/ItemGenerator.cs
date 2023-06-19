using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject debuffPre;
    public GameObject ShotUPPre;
    public GameObject SpeedUPPre;
    
    float span=1.5f;
    float delta;

    void Start()
    {
        
    }

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            int it = Random.Range(-10, 11);
            GameObject sp = Instantiate(SpeedUPPre);
            sp.transform.position = new Vector3(it, 5.7f, 0);
            delta = 0;
            Debug.Log("aaaaa");
        }

        if (delta > span)
        {
            int it2 = Random.Range(-10, 11);
            GameObject sh = Instantiate(ShotUPPre);
            sh.transform.position = new Vector3(it2, 5.7f, 0);
            delta = 0;
            Debug.Log("iiiiii");
        }

        if(delta > span)
        {
            int it3 = Random.Range(-10, 11);
            GameObject de = Instantiate(debuffPre);
            de.transform.position = new Vector3(it3, 5.7f, 0);
            delta = 0;
            Debug.Log("uuuuuu");
        }

    }
}