using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyContoller : MonoBehaviour
{
    float span;
    float delta;

    GameObject player;
    public GameObject EnemyShotPre;  //�v���n�u�̕ۑ�

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //EnemyShot��G���琶����Player�ɔ�΂�
        delta += Time.deltaTime;
        if (span < delta)
        {
            Vector3 targetRotate = player.transform.position - this.transform.position;
            Instantiate(EnemyShotPre, transform.position, Quaternion.FromToRotation(Vector3.up, targetRotate));
            span = Random.Range(0.5f,2f);
            delta = 0;
        }

        //Enemy�̉��ړ�
        transform.Translate(-0.02f, 0, 0);

        if(transform.position.x < -15.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ShotTag")
        {
            Destroy(gameObject);
        }
    }

}
