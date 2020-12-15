using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cansel : MonoBehaviour
{
    //数字を表示するテキスト
    Text CounterText;

    //処理を行う数字
    public Text N;

    //今の数字
    private int Now;

    public void Start()
    {
        Now = 0;
        this.CounterText=GameObject.Find("number").GetComponent<Text>();
    }
    public void IntN()
    {
        
        CounterText.text = "";
        
        //指定した数になった時の処理を書く
    }
}
