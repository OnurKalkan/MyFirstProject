using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int x = 2_147_000_000;//x bir integerdir veya sayidir
    public float y = 5.6f;//ondalikli sayilar
    public string name = "char_name 01*";//karakter saklamak icin
    public bool isTrue = true;//dogru yanlis secimi

    private void Start()
    {      
        print(x);
        print(y);
        print(name);
        print(isTrue);
        GetComponent<BoxCollider>().isTrigger = true;
    }

    private void Update()
    {
        
    }
}
