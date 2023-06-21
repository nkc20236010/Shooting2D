using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyContoller : MonoBehaviour
{
    [SerializeField] float speed;

    float span;
    float delta;

    GameObject player;
    public GameObject EnemyShotPre;  //�v���n�u�̕ۑ�
    public GameObject ShotUPPre;     //�V���b�gUP�̃v���n�u
    public GameObject SpeedUPPre;    //�X�s�[�hUP�̃v���n�u

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
            span = Random.Range(0.5f, 2f);
            delta = 0;
        }

        //Enemy�̉��ړ�
        transform.position += transform.up * speed * Time.deltaTime;

        if (transform.position.x < -15.0f)
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

    public void OnDestroy()
    {
        //�����_���ɑI������A�C�e���̃C���f�N�X
        int itemIndex = Random.Range(0, 2);

        if (itemIndex == 0)
        {
            //�A�C�e��(�V���b�gUP)����
            Instantiate(ShotUPPre, transform.position, Quaternion.identity);
        }

        else
        {
            //�A�C�e��(�X�s�[�hUP)����
            Instantiate(SpeedUPPre, transform.position, Quaternion.identity);
        }

    }
}
