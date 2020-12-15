using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject shop;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shop", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shop()
    {
        shop.gameObject.SetActive(true);
    }
}
