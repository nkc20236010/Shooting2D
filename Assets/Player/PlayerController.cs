using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    [SerializeField] private float speed;
    [SerializeField] private float _maxX;
    [SerializeField] private float _minX;
    [SerializeField] private float _maxY;
    [SerializeField] private float _minY;

    void Start()
    {
        
    }

    void Update()
    {
        //pos.x = Input.GetAxisRaw("Horizontal");
        //pos.y = Input.GetAxisRaw("Vertical");

        Vector3 pos = transform.position;

        //âÊñ ì‡à⁄ìÆêßå¿
        pos.x = Mathf.Clamp(pos.x, _maxX, _minY);
    }
}
