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
    public GameObject EnemyShotPre;  //プレハブの保存
    public GameObject ShotUPPre;     //ショットUPのプレハブ
    public GameObject SpeedUPPre;    //スピードUPのプレハブ

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //EnemyShotを敵から生成しPlayerに飛ばす
        delta += Time.deltaTime;
        if (span < delta)
        {
            Vector3 targetRotate = player.transform.position - this.transform.position;
            Instantiate(EnemyShotPre, transform.position, Quaternion.FromToRotation(Vector3.up, targetRotate));
            span = Random.Range(0.5f, 2f);
            delta = 0;
        }

        //Enemyの横移動
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
        //ランダムに選択するアイテムのインデクス
        int itemIndex = Random.Range(0, 2);

        if (itemIndex == 0)
        {
            //アイテム(ショットUP)生成
            Instantiate(ShotUPPre, transform.position, Quaternion.identity);
        }

        else
        {
            //アイテム(スピードUP)生成
            Instantiate(SpeedUPPre, transform.position, Quaternion.identity);
        }

    }
}
