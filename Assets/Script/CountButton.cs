using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountButton : MonoBehaviour
{

    //足すメソッド
    public void Plus()
    {
        FindObjectOfType<CountGameObject>().Plus();
    }

    //引くメソッド
    public void Minus()
    {
        FindObjectOfType<CountGameObject>().Minus();
    }

    public void IntN()
    {
        //指定した数になった時の処理を書く
    }
}
