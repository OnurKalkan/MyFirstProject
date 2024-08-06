using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops2 : MonoBehaviour
{
    public int health = 100;
    public GameObject cubeMan;
    public GameObject[] cubePersons;

    private void Start()
    {
        //print(cubePersons[6].transform.GetChild(0).name);
        string minHealthChar = "";
        int minHealth = 2000;
        for (int i = 0; i < cubePersons.Length; i++)
        {
            if (cubePersons[i].GetComponent<CubePerson>().health < minHealth)
            {
                minHealthChar = cubePersons[i].name;
                minHealth = cubePersons[i].GetComponent<CubePerson>().health;
            }                
        }
        for (int i = 0; i < cubePersons.Length; i++)
        {
            if (cubePersons[i].name == minHealthChar)
                print("Lowest health character: " + cubePersons[i].name);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            BuyuAtma();
        }
    }

    public void BuyuAtma()
    {
        GameObject[] cubePersons = GameObject.FindGameObjectsWithTag("CubePerson");
        for (int x = 0; x < 7; x++)
        {
            cubePersons[x].GetComponent<CubePerson>().health -= 10;
            if (cubePersons[x].GetComponent<CubePerson>().health <= 0)
            {
                cubePersons[x].GetComponent<Rigidbody>().useGravity = true;
                cubePersons[x].GetComponent<Rigidbody>().isKinematic = false;
                int y = 0;
                while (y < 5)
                {
                    cubePersons[x].transform.GetChild(y).GetComponent<Rigidbody>().useGravity = true;
                    cubePersons[x].transform.GetChild(y).GetComponent<Rigidbody>().isKinematic = false;
                    y++;
                }
            }
        }
    }
}
