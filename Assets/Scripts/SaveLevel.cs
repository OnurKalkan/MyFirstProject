using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLevel : MonoBehaviour
{
    public int levelNo;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("currentLevel", levelNo);
        print("current level number saved!");
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.DeleteKey("currentLevel");
        //print("level number got reset!");
    }
}
