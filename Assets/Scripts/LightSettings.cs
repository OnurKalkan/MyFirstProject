using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        
        GetComponent<Light>().intensity = 5;
    }
}
