using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int hit = 0;
    [SerializeField] float span;

    public static float speed = 0.05f;
    public static int power = 0;

    public GameObject ShotPre;
    GameObject Player;
    GameObject gameDirector;

    Vector3 dir = Vector3.zero;

    float delta = 0;
    int EnemyKill = 0;

    Animator PlayerAnime;

    //x軸方向の移動範囲の最小値
    [SerializeField] private float _minX = -10.5f;
    //x軸方向の移動範囲の最大値
    [SerializeField] private float _maxX = 10.5f;
    //y軸方向の移動範囲の最小値
    [SerializeField] private float _minY = -4.5f;
    //y軸方向の移動範囲の最大値
    [SerializeField] private float _maxY = 4.5f;


    void Start()
    {
        gameDirector = GameObject.Find("GameDirector");
        PlayerAnime = GetComponent<Animator>();
    }

    public void Update()
    {
        EnemyKill = gameDirector.GetComponent<GameDirector>().KillCount;

        //プレイヤーの移動
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x * speed, y * speed, 0);
        transform.position += dir.normalized * speed * Time.deltaTime;
        PlayerAnime.SetFloat("UpDown", y);

        Vector3 pos = transform.position;

        //x軸方向の移動範囲制限
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);
        //y軸方向の移動範囲制限
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;

        Shot();

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "EnemyTag")
        {
            //メソッド内の情報を取得
            gameDirector.GetComponent<GameDirector>().HitCounter();

            //Enemyに当たったらscoreの値が減る
            GameDirector.score -= 1000;

            //EnemyTagを持ったオブジェクトに当たると消える
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "EnemyShotTag")
        {
            GameDirector.score -= 500;

            //EnemyShotTagを持ったオブジェクトに当たると消える
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "ShotUPtag")
        {
            power += 1;
            
        //ShotUPtagを持ったオブジェクトに当たると消える
            Destroy(collider.gameObject);
        }
    }


    public void Shot()
    {
        //Cキーを押すとpowerが増える
        if (Input.GetKeyDown(KeyCode.C))
        {
            power = (power + 1) % 13;
        }

        //Zキーを押すと火の玉が出る
        if (Input.GetKeyDown(KeyCode.Z))
        {
            for (int i = -power; i < power + 1; i++)
            {
                Vector3 eulerRotate = transform.root.eulerAngles + new Vector3(0, 0, 15f * i);
                Quaternion quateRotate = Quaternion.Euler(eulerRotate);
                Instantiate(ShotPre, transform.position, quateRotate);
            }
        }
    }
}
