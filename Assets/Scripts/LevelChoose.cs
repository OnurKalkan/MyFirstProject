using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{
    int levelNumber = 10, x;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("currentLevel", 1);
        //PlayerPrefs.SetFloat("someDegree", 5.5f);
        //PlayerPrefs.SetString("someText", "random Text");

        levelNumber = PlayerPrefs.GetInt("currentLevel", 1);
        print(levelNumber);

        switch (levelNumber)
        {            
            case 1: 
                SceneManager.LoadScene(1);            
                break;
            case 2:
                SceneManager.LoadScene(2);
                break;
            case 3:
                SceneManager.LoadScene(3);
                break;
        }
    }
}
