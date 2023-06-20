using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpGenerator : MonoBehaviour
{
    public GameObject SpeedUPPre;

    float span = 5f;
    float delta;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            int it = Random.Range(-10, 11);
            GameObject sp = Instantiate(SpeedUPPre);
            sp.transform.position = new Vector3(it, 5.7f, 0);
            delta = 0;
        }
    }
}
