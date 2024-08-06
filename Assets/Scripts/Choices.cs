using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Choices : MonoBehaviour
{
    public TextMeshPro charInfo;
    public string charName = "The Cube";    
    public int charLevel;
    public float charHealth;
    public bool isAlive;
    string livingCondition, healthStatus, gradeResult;
    public int studentGrade;

    void Start()
    {
        //if(isAlive == true)
        //{
        //    livingCondition = "alive";
        //}
        //else
        //{
        //    livingCondition = "dead";
        //}

        if(charHealth > 75)
        {
            healthStatus = "good";
            charInfo.color = Color.green;
            livingCondition = "alive";
            isAlive = true;
        }
        else if (charHealth > 40)
        {
            healthStatus = "fine";
            charInfo.color = Color.yellow;
            livingCondition = "alive";
            isAlive = true;
        }
        else if (charHealth == 0)
        {
            healthStatus = "no";
            livingCondition = "dead";
            isAlive = false;
            charInfo.color = Color.red;
        }        
        if(studentGrade > 90)
        {
            gradeResult = "A";
        }
        else if (studentGrade > 70)
        {
            gradeResult = "B";
        }
        else if (studentGrade > 50)
        {
            gradeResult = "C";
        }
        else
        {
            gradeResult = "F";
        }

        charInfo.text = "Name: " + charName + "\nLevel: " +
            charLevel.ToString() + "\nHealth: " + charHealth + "\nLiving Condition: " + livingCondition
            + "\nHealth Status: " + healthStatus + "\n" + gradeResult;
    }
}
