using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public int KillCount;
    int hit = 0;
    public static float score;

    [SerializeField] GameObject TimeGauge;
    [SerializeField] Text Km;
    [SerializeField] Text Kill;
    [SerializeField] float countTime;
    [SerializeField] float time;

    void Update()
    {
        //敵を倒した数
        Kill.GetComponent<Text>().text = KillCount.ToString("000") + "Kill";

        //移動距離
        score += Time.deltaTime * 60;
        Km.GetComponent<Text>().text = score.ToString("000000") + "Km";

        //時間経過
        time -= 1.0f / countTime * Time.deltaTime;
        TimeGauge.GetComponent<Image>().fillAmount -= 1.0f / countTime * Time.deltaTime;

        //0秒になったらClearSceneに移動
        if (time < 0)
        {
            KillScoer.Kill = KillCount;
            KmScoer.Km = score;
            SceneManager.LoadScene("ClearScene");
        }

    }
    public void HitCounter()
    {
        hit++;
    }
    public void KillCounter()
    {
        KillCount++;
    }

}
