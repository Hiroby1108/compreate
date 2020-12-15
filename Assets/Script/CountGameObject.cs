using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountGameObject : MonoBehaviour
{
    //今の数字
    public int Now;

    //足す数字
    public int PlusInt = 1;

    //引く数字
    public int MinusInt = 1;

    //数を表示するテキスト
    public Text CounterText;

    //処理を行う数
    public int N;

    public void Start()
    {
        Now = 0;
        CounterText.GetComponent<Text>();
    }

    public void Plus()
    {
        Now += PlusInt;
        CounterText.text = Now.ToString();
        if (Now == N)
        {
            IntN();
        }
    }

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
        FindObjectOfType<CountButton>().IntN();
    }
}
