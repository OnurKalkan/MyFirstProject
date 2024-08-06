using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public GameObject cubeSample;

    void Start()
    {
        int x = 0;        
        float cubeSpaceX = 0f;
        //while (x < 5)
        //{
        //    Instantiate(cubeSample, cubeSample.transform.position + new Vector3(cubeSpaceX, 0, 0)
        //        , Quaternion.identity);            
        //    int y = 0;
        //    float cubeSpaceY = 1.1f;
        //    while (y < 4)
        //    {
        //        Instantiate(cubeSample, cubeSample.transform.position + new Vector3(cubeSpaceX, cubeSpaceY, 0)
        //        , Quaternion.identity);
        //        y++;
        //        //print("y: " + y);
        //        cubeSpaceY = cubeSpaceY + 1.1f;
        //    }
        //    x++;
        //    cubeSpaceX = cubeSpaceX - 1.1f;
        //}
        //bu for kodu cube'lerden 5x5 grid olusturmak icin
        for (int i = 0; i < 5; i++)
        {
            Instantiate(cubeSample, cubeSample.transform.position + new Vector3(cubeSpaceX, 0, 0), Quaternion.identity);
            float cubeSpaceY = 1.1f;
            for (int j = 0; j < 4; j++) 
            {
                Instantiate(cubeSample, cubeSample.transform.position + new Vector3(cubeSpaceX, cubeSpaceY, 0), Quaternion.identity);
                cubeSpaceY = cubeSpaceY + 1.1f;
            }
            cubeSpaceX = cubeSpaceX - 1.1f;
        }
    }
}
