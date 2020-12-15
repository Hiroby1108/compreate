using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Judgement : MonoBehaviour
{

    //一人目
    public GameObject Change0;
    public GameObject next;
    public GameObject next2;
    public GameObject next3;
    public GameObject next4;
    public GameObject face;
    //二人目
    public GameObject Change;
    public GameObject next5;
    public GameObject next6;
    public GameObject next7;
    public GameObject next8;
    public GameObject next9;
    public GameObject next10;
    public GameObject next11;
    public GameObject next12;
    public GameObject next13;
    public GameObject next14;
    public GameObject face2;
    //3人目
    public GameObject Change2;
    public GameObject next15;
    public GameObject next16;
    public GameObject next17;
    public GameObject next18;
    public GameObject next19;
    public GameObject next20;
    public GameObject next21;
    public GameObject next22;
    public GameObject face3;
    //4人目
    public GameObject Change3;
    public GameObject next23;
    public GameObject next24;
    public GameObject next25;
    public GameObject next26;
    public GameObject next27;
    public GameObject next28;
    public GameObject next29;
    public GameObject next30;
    public GameObject next31;
    public GameObject next32;
    public GameObject face4;
    public GameObject face5;
    //GameOver
    public GameObject Over;
    public GameObject Mob;
    //delite
    public GameObject Hello1;
    public GameObject Hello2;
    public GameObject seeyou1;
    public GameObject seeyou2;

    private Text JudgementText;

    private int x;

    private int y;

    private int z;　//いらっしゃいませのところ

    private int s;　//ありがとうございましたのところ

    private float timer;

    private float timer2;

    void Start()
    {
        Invoke("Timer", 5);
        x =577;　//金額
        this.JudgementText = GameObject.Find("number").GetComponent<Text>();　//レジ打ちした金額
        z = 0;
        s = 10;
       
    }
    void Update()
    {
        if (z == 3 && Change3.activeSelf == true)
        {
            timer += Time.deltaTime;
            Debug.Log("時間:" + timer);
        }
        if (z == 2 && Change2.activeSelf == true)
        {
            timer += Time.deltaTime;
            Debug.Log("時間:" + timer);
        }
        if (z == 1 && Change.activeSelf == true)
        {
            timer += Time.deltaTime;
            Debug.Log("時間:" + timer);
        }
        if (z == 0 && Change0.activeSelf == true)
        {
            timer += Time.deltaTime;
            Debug.Log("時間:" + timer);
        }


        if (s == 6 && Change3.activeSelf == false)
        {
            timer2 += Time.deltaTime;
            Debug.Log("時間2:" + timer2);
        }
        if (s == 4 && Change2.activeSelf == false && Change3.activeSelf == false)
        {
            timer2 += Time.deltaTime;
            Debug.Log("時間2:" + timer2);
        }
        if (s == 2 && Change.activeSelf == false&& Change2.activeSelf == false)
        {
            timer2 += Time.deltaTime;
            Debug.Log("時間2:" + timer2);
        }
        if (s == 0 && Change0.activeSelf == false&& Change.activeSelf == false)
        {
            timer2 += Time.deltaTime;
            Debug.Log("時間2:" + timer2);
        }
    }

   public void Judging()
    {
        Judge();　//レジ入力した金額を当てはめる

        if (y==x)　//xは値段　yはレジ入力
        {
            
            Vinyl();
            JudgeY(); //あっている場合
            
        }
        else {
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
        

        if (x == 698)
        {
            JudgementText.text = "";
            GameObject.Find("四人目の客").SetActive(false);
            face3.gameObject.SetActive(false);
            face4.gameObject.SetActive(true);
            x = 698;
            s = 6;
            z = 4;
            timer = 0;
            timer2 = 0;
            Invoke("GameOver", 5);
        }
        if (x == 237)
        {
            JudgementText.text = "";
            next29.gameObject.SetActive(false);
            next30.gameObject.SetActive(false);
            next31.gameObject.SetActive(true);
            next32.gameObject.SetActive(true);
            x = 698;
        }
        if (x == 159)
        {
            JudgementText.text = "";
            next27.gameObject.SetActive(false);
            next28.gameObject.SetActive(false);
            next29.gameObject.SetActive(true);
            next30.gameObject.SetActive(true);
            x = 237;
        }
        if (x == 128)
        {
            JudgementText.text = "";
            next25.gameObject.SetActive(false);
            next26.gameObject.SetActive(false);
            next27.gameObject.SetActive(true);
            next28.gameObject.SetActive(true);
            x = 159;
        }
        if (x == 113)
        {
            JudgementText.text = "";
            next23.gameObject.SetActive(false);
            next24.gameObject.SetActive(false);
            next25.gameObject.SetActive(true);
            next26.gameObject.SetActive(true);
            x = 128;
        }
        if (x == 893)
        {
            JudgementText.text = "";
            GameObject.Find("三人目の客").SetActive(false);
            face2.gameObject.SetActive(false);
            face3.gameObject.SetActive(true);
            Invoke("Second", 5);
            s = 4;
            z = 3;
            timer = 0;
            timer2 = 0;
            x = 113;
        }
        if (x == 225)
        {
            JudgementText.text = "";
            next19.gameObject.SetActive(false);
            next20.gameObject.SetActive(false);
            next21.gameObject.SetActive(true);
            next22.gameObject.SetActive(true);
            x = 893;
        }
        if (x == 268)
        {
            JudgementText.text = "";
            next17.gameObject.SetActive(false);
            next18.gameObject.SetActive(false);
            next19.gameObject.SetActive(true);
            next20.gameObject.SetActive(true);
            x = 225;
        }
        if (x == 387)
        {
            JudgementText.text = "";
            next15.gameObject.SetActive(false);
            next16.gameObject.SetActive(false);
            next17.gameObject.SetActive(true);
            next18.gameObject.SetActive(true);
            x = 268;
        }
       
        if (x == 281)
        {
            JudgementText.text = "";
            next11.gameObject.SetActive(false);
            next12.gameObject.SetActive(false);
            next13.gameObject.SetActive(true);
            next14.gameObject.SetActive(true);
            x = 3;
        }
        if (x == 243)
        {
            JudgementText.text = "";
            next9.gameObject.SetActive(false);
            next10.gameObject.SetActive(false);
            next11.gameObject.SetActive(true);
            next12.gameObject.SetActive(true);
            x = 281;
        }
        if (x == 585)
        {
            JudgementText.text = "";
            next7.gameObject.SetActive(false);
            next8.gameObject.SetActive(false);
            next9.gameObject.SetActive(true);
            next10.gameObject.SetActive(true);
            x = 243;
        }
        if (x == 375)
        {
            JudgementText.text = "";
            next5.gameObject.SetActive(false);
            next6.gameObject.SetActive(false);
            next7.gameObject.SetActive(true);
            next8.gameObject.SetActive(true);
            Debug.Log("数字です:" + y);
            x = 585;
        }
        if (x == 153)
        {
            JudgementText.text = "";
            GameObject.Find("一人目の客").SetActive(false);
            face5.gameObject.SetActive(false);
            face.gameObject.SetActive(true);
            Invoke("Second", 5);
            s = 0;
            z = 1;
            timer = 0;
            timer2 = 0;

            x = 375;
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
            Debug.Log("数字かも:" + y);
            x = 126;
            
        }
    
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
        
        if (x == 375)
        {
            Change.gameObject.SetActive(true);
        }
        if (x == 20)
        {
            x = 387;
            Change2.gameObject.SetActive(true);
            Debug.Log("change:" + y);
        }
        if (x == 113)
        {
            Change3.gameObject.SetActive(true);
        }

    }
    public void Vinyl()
    {
        if (GameObject.Find("二人目の客")==true)
        {
            if (x == 3)
            {
                s = 2;
                z = 2;
                x = 20;
                timer = 0;
                timer2 = 0;
                Invoke("Second", 5);
                JudgementText.text = "";
                GameObject.Find("二人目の客").SetActive(false);
                face.gameObject.SetActive(false);
                face2.gameObject.SetActive(true);
                Debug.Log("袋:" + y);
                
                
            }
        }
    }
    public void GameOver()
    {
        GameObject.Find("レジ").SetActive(false);
        GameObject.Find("コンビニ店員").SetActive(false);
        Over.gameObject.SetActive(true);
        Mob.gameObject.SetActive(true);
        Invoke("SceneChange", 4);
        
        }
    public void SceneChange()
    {

        SceneManager.LoadScene("Result");
    }
    public void Hello(){

      

        if (z == 3 && Change3.activeSelf == true)
        {
            

            if (timer < 3.0f && y == 893)
            {
                face3.gameObject.SetActive(false);
                face4.gameObject.SetActive(true);
                Hello1.gameObject.SetActive(true);
                // ここが５秒以内にボタンが押されたらなら実行される
                z = 4;
                timer = 0;
                Debug.Log("こんちわ4");
                Invoke("delite", 2);
            }
            if (timer > 3.0f || y != 893)
            {
                Hello2.gameObject.SetActive(true);
                face5.gameObject.SetActive(true);
                // ここは５秒を超えた後にボタンが押されたら実行される
                z = 4;
                timer = 0;
                Debug.Log("なにやってんだよぉ4");
                Invoke("delite", 2);
            }
        }

        if (z == 2 && Change2.activeSelf == true)
        {
           

            if (timer < 3.0f && y == 3)
            {
                Hello1.gameObject.SetActive(true);
                face2.gameObject.SetActive(false);
                face3.gameObject.SetActive(true);
                // ここが５秒以内にボタンが押されたらなら実行される
                z = 3;
                timer = 0;
                Debug.Log("こんちわ3");
                Invoke("delite", 2);
            }
            if (timer > 3.0f || y != 3)
            {
                Hello2.gameObject.SetActive(true);
                face5.gameObject.SetActive(true);
                // ここは５秒を超えた後にボタンが押されたら実行される
                z = 3;
                timer = 0;
                Debug.Log("なにやってんだよぉ3");
                Invoke("delite", 2);
            }
        }

        if (z == 1 && Change.activeSelf == true)
            {
               

            if (timer < 3.0f && y == 153)
            {
                Hello1.gameObject.SetActive(true);
                face.gameObject.SetActive(false);
                face2.gameObject.SetActive(true);
                // ここが５秒以内にボタンが押されたらなら実行される
                z = 2;
                timer = 0;
                Debug.Log("こんちわ2");
                Invoke("delite", 2);
            }
            if (timer > 3.0f|| y != 153)
            {
                Hello2.gameObject.SetActive(true);
                face5.gameObject.SetActive(true);
                // ここは５秒を超えた後にボタンが押されたら実行される
                z = 2;
                timer = 0;
                Debug.Log("なにやってんだよぉ2");
                Invoke("delite", 2);
            }
        }

            if (z == 0 && Change0.activeSelf == true)
            {
               
            if (timer < 3.0f && y == 0)
            {
                Hello1.gameObject.SetActive(true);
                face5.gameObject.SetActive(false);
                face.gameObject.SetActive(true);
                // ここが５秒以内にボタンが押されたらなら実行される
                z = 1;
                timer = 0;
                Debug.Log("こんちわ");
                Invoke("delite", 2);
            }
            if (timer > 3.0f || y!=0)
            {
                Hello2.gameObject.SetActive(true);
                face5.gameObject.SetActive(true);
                // ここは５秒を超えた後にボタンが押されたら実行される
                z = 1;
                timer = 0;
                Debug.Log("なにやってんだよぉ");
                Invoke("delite", 2);
            }
        }
        
        }

    public void seeyou()
    {



        if (s == 6 && Change3.activeSelf == false)
        {


            if (timer2 < 3.0f && y == 698)
            {
                seeyou1.gameObject.SetActive(true);
                face4.gameObject.SetActive(true);
                face3.gameObject.SetActive(false);
                // ここが５秒以内にボタンが押されたらなら実行される
                s = 7;
                timer2 = 0;
                Debug.Log("THX4");
                Invoke("delite", 2);
            }
            if (timer2 > 3.0f || y != 698)
            {
                seeyou2.gameObject.SetActive(true);
                face5.gameObject.SetActive(true);
                // ここは５秒を超えた後にボタンが押されたら実行される
                s = 7;
                timer2 = 0;
                Debug.Log("WHAT4");
                Invoke("delite", 2);
            }
        }

        if (s == 4 && Change2.activeSelf == false)
        {


            if (timer2 < 3.0f && y == 893)
            {
                seeyou1.gameObject.SetActive(true);
                face3.gameObject.SetActive(true);
                face2.gameObject.SetActive(false);
                // ここが５秒以内にボタンが押されたらなら実行される
                s = 5;
                timer2 = 0;
                Debug.Log("THX3");
                Invoke("delite", 2);
            }
            if (timer2 > 3.0f || y != 893)
            {
                seeyou2.gameObject.SetActive(true);
                face5.gameObject.SetActive(true);
                // ここは５秒を超えた後にボタンが押されたら実行される
                s = 5;
                timer2 = 0;
                Debug.Log("WHAT3");
                Invoke("delite", 2);
            }
        }

        if (s == 2 && Change.activeSelf == false)
        {


            if (timer2 < 3.0f && y == 3)
            {
                seeyou1.gameObject.SetActive(true);
                face2.gameObject.SetActive(true);
                face.gameObject.SetActive(false);
                // ここが５秒以内にボタンが押されたらなら実行される
                s = 3;
                timer2 = 0;
                Debug.Log("THX2");
                Invoke("delite", 2);
            }
            if (timer2 > 3.0f || y != 3)
            {
                seeyou2.gameObject.SetActive(true);
                face5.gameObject.SetActive(true);
                // ここは５秒を超えた後にボタンが押されたら実行される
                s = 3;
                timer2 = 0;
                Debug.Log("WHAT2");
                Invoke("delite", 2);
            }
        }

        if (s == 0 && Change0.activeSelf == false)
        {

            if (timer2 < 3.0f && y == 153)
            {
                seeyou1.gameObject.SetActive(true);
                face.gameObject.SetActive(true);
                face5.gameObject.SetActive(false);
                // ここが５秒以内にボタンが押されたらなら実行される
                s = 1;
                timer2 = 0;
                Debug.Log("THX");
                Invoke("delite", 2);
            }
            if (timer2 > 3.0f || y != 153)
            {
                seeyou2.gameObject.SetActive(true);
                face5.gameObject.SetActive(true);
                // ここは５秒を超えた後にボタンが押されたら実行される
                s = 1;
                timer2 = 0;
                Debug.Log("WHAT");
                Invoke("delite", 2);
            }
        }

    }
    public void delite()
    {
        Hello1.gameObject.SetActive(false);
        Hello2.gameObject.SetActive(false);
        seeyou1.gameObject.SetActive(false);
        seeyou2.gameObject.SetActive(false);
    }
}
