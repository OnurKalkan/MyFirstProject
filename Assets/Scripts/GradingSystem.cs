using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradingSystem : MonoBehaviour
{
    [Range(0, 100)] public int studentGrade, controlNumber = 37;
    public string letterGrade;
    string studentMessage;
    bool passed;

    // Start is called before the first frame update
    void Start()
    {
        if (studentGrade >= 40 && studentGrade < 50)//< smaller, > greater, <= equal and smaller, >= equal and greater
        {
            letterGrade = "D";
            print("1");
        }
        else if (studentGrade >= 50 && studentGrade < 70)// && and, || or
        {
            letterGrade = "C";
            print("2");
        }
        else if(studentGrade >= 70 && studentGrade < 90)// != not equal
        {
            letterGrade = "B";
            print("3");
        }
        else if( studentGrade >= 90 && studentGrade <= 100)
        {
            letterGrade = "A";
            print("4");
        }
        else
        {
            letterGrade = "F";
            print("5");
        }        

        if(letterGrade == "A")// || studentGrade > controlNumber) && passed != false)
        {
            studentMessage = "Congrats you got an A!!";
        }
        else if (letterGrade == "B")
        {
            studentMessage = "You got a B";
        }
        else if (letterGrade == "C")
        {
            studentMessage = "You got a C, please work harder";
        }
        else if (letterGrade == "D")
        {
            studentMessage = "You got a D, not a good grade";
        }
        else
        {
            studentMessage = "You got a F, you failed!";
        }

        print("Student's letter grade is: " + letterGrade + "\n" + studentMessage);

        
        switch (letterGrade)
        {
            case "A":
                studentMessage = "Congrats you got an A!!";
                break;
            case "B":
                studentMessage = "You got a B";
                break;
            case "C":
                studentMessage = "You got a C, please work harder";
                break;
            case "D":
                studentMessage = "You got a D, not a good grade";
                break;
            default: studentMessage = "You got a F, you failed!";
                break;
        }
    }
}
