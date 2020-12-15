using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultChange : MonoBehaviour
{
    private int x=0;

    public GameObject Slide;
    public GameObject Slide2;
    public GameObject Slide3;
    public GameObject Slide4;
    public GameObject Slide5;
    public GameObject Slide6;
    public GameObject Slide7;
    public GameObject Slide8;
    public GameObject Slide9;
    public GameObject Slide10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Result()
    {
        if (x == 9)
        {

            Slide10.gameObject.SetActive(true);
            Slide9.gameObject.SetActive(false);
            x = 10;
            GameObject.Find("Change").SetActive(false);
            Invoke("End", 30);
        }
        if (x == 8)
        {

            Slide9.gameObject.SetActive(true);
            Slide8.gameObject.SetActive(false);
            Slide7.gameObject.SetActive(false);
            x = 9;
        }
        if (x == 7)
        {

            Slide8.gameObject.SetActive(true);
            x = 8;
        }
        if (x == 6)
        {

            Slide7.gameObject.SetActive(true);
            Slide6.gameObject.SetActive(false);
            Slide5.gameObject.SetActive(false);
            Slide4.gameObject.SetActive(false);
            Slide3.gameObject.SetActive(false);
            Slide2.gameObject.SetActive(false);
            Slide.gameObject.SetActive(false);
            GameObject.Find("リザルト（想定）").SetActive(false);
            
            x = 7;
        }
        if (x == 5)
        {

            Slide6.gameObject.SetActive(true);
            x = 6;
        }
        if (x == 4)
        {

            Slide5.gameObject.SetActive(true);
            x = 5;
        }
        if (x == 3)
        {
            
            Slide4.gameObject.SetActive(true);
            x = 4;
        }
        if (x == 2)
        {
           
            Slide3.gameObject.SetActive(true);
            x = 3;
        }
        if (x == 1)
        {
            
            Slide2.gameObject.SetActive(true);
            x = 2;
        }
        if (x == 0)
        {
            
            Slide.gameObject.SetActive(true);
            x = 1;
        }
        
    }
    public void End()
    {
        Debug.Log("終わり");
        Application.Quit();
    }
}
