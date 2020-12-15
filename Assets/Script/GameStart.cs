using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// 2.Scene関係の処理を行うときに必要なライブラリ
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void State() { 
        SceneManager.LoadScene("説明");
    }
}
