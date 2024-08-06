using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject[] cubePersons = GameObject.FindGameObjectsWithTag("CubePerson");
            for (int x = 0; x < 7; x++)
            {
                cubePersons[x].GetComponent<CubePerson>().health -= 10;
                if(cubePersons[x].GetComponent<CubePerson>().health <= 0)
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
}
