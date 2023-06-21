using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownContoller : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.right * 0.04f * (Mathf.Sin(Time.time * 5f));
    }
}
