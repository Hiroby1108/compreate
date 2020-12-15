using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class SecondJudg : MonoBehaviour
{
    public GameObject next;
    public GameObject next2;
    public GameObject next3;
    public GameObject next4;
    public GameObject face;
    public GameObject Change;


    private Text JudgementText;

    private int x;

    private int y;

    void Start()
    {
        x = 577;　//金額
        this.JudgementText = GameObject.Find("number").GetComponent<Text>(); //レジ打ちした金額


    }

    public void Judging()
    {
        Judge();　//レジ入力した金額を当てはめる

        if (y == x)　//xは値段　yはレジ入力
        {
            JudgeY(); //あっている場合

        }
        else
        {
            JudgeN(); //あっていない場合
        }
    }
    public void Judge()
    {
        y = Convert.ToInt32(JudgementText.text);

        //Debug.Log("数字:" + y);

    }

    public void JudgeY()
    {


        if (x == 153)
        {
            JudgementText.text = "";
            GameObject.Find("二人目の客").SetActive(false);
            face.gameObject.SetActive(true);
            Invoke("Second", 5);
        }
        if (x == 126)
        {
            JudgementText.text = "";
            next.gameObject.SetActive(false);
            next2.gameObject.SetActive(false);
            next3.gameObject.SetActive(true);
            next4.gameObject.SetActive(true);
            x = 153;
        }
        if (x == 577)
        {
            JudgementText.text = "";
            GameObject.Find("コンビニ弁当").SetActive(false);

            next.gameObject.SetActive(true);
            next2.gameObject.SetActive(true);
            Debug.Log("数字です:" + y);
            x = 126;
        }

        //このあとに別のscript（会計等を行わせたい）
        //不満値も貯めて強制終了のしすてむを作る
    }

    public void JudgeN()
    {
        //
        //ここで音を鳴らすようにするシステムを付け加える？
        JudgementText.text = "";
        Debug.Log("数字かも:" + y);
    }
    public void Second()
    {
        Change.gameObject.SetActive(true);
    }
}
