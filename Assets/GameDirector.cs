using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public float score;

    GameObject kyori;
    GameObject TimeGauge;

    [SerializeField] float time;
    [SerializeField] float countdown;

    void Start()
    {
        TimeGauge = GameObject.Find("TimeGauge");
        kyori = GameObject.Find("Kyori");
    }

    void Update()
    {
        score += Time.deltaTime;
        kyori.GetComponent<Text>().text = score.ToString("F2") + "km";

        //if(countdown < 0)
        //{
        //    SceneManager.LoadScene("GameScene");
        //}

    }

    public void CountTime()
    {
        //time += 0.1f / countdown * Time.deltaTime;
        //TimeGauge.GetComponent<GameObject>().fillAmount -=0.1f/countdown*Time.deltaTime;
    }

}
