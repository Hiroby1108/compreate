using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter6 : MonoBehaviour
{
    //数字を表示するテキスト
    public Text CounterText;

    //処理を行う数字
    public int N;

    //足す数
    public int PlusInt = 6;

    //引く数
    public int MinusInt = 1;

    //今の数字
    private int Now;

    public void Start()
    {
        Now = 0;
        CounterText.GetComponent<Text>();
    }

    //足すメソッド
    public void Plus()
    {
        Now = PlusInt;
        CounterText.text += Now.ToString();
        if (Now == N)
        {
            IntN();
        }
    }
    //引くメソッド
    public void Minus()
    {
        Now -= MinusInt;
        CounterText.text = Now.ToString();
        if (Now == N)
        {
            IntN();
        }
    }

    public void IntN()
    {
        //指定した数になった時の処理を書く
    }
}
