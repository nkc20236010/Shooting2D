using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownContoller : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.up * 0.02f * (Mathf.Sin(Time.time * 5f));
    }
}
