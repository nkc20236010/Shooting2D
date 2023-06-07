using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator PlayerAmime;

    [SerializeField] private float speed;
    [SerializeField] private float _maxX = 9.5f;
    [SerializeField] private float _minX = -9.5f;
    [SerializeField] private float _maxY = 4.5f;
    [SerializeField] private float _minY = -4.5f;

    void Start()
    {
        PlayerAmime = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x * speed, y * speed);
        PlayerAmime.SetFloat("UpDown",y);

        Vector3 pos = transform.position;

        //画面内移動制限
        //x軸方向も移動範囲制限
        pos.x = Mathf.Clamp(pos.x, _maxX, _minX);
        //y軸方向の移動範囲制限
        pos.y = Mathf.Clamp(pos.y, _maxY, _minY);
    }
}
