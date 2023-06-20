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
        //“G‚ğ“|‚µ‚½”
        Kill.GetComponent<Text>().text = KillCount.ToString("000") + "Kill";

        //ˆÚ“®‹——£
        score += Time.deltaTime * 60;
        Km.GetComponent<Text>().text = score.ToString("000000") + "Km";

        //ŠÔŒo‰ß
        time -= 1.0f / countTime * Time.deltaTime;
        TimeGauge.GetComponent<Image>().fillAmount -= 1.0f / countTime * Time.deltaTime;

        //0•b‚É‚È‚Á‚½‚çClearScene‚ÉˆÚ“®
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
