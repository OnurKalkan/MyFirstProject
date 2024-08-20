using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public Animator anim;
    public Transform playerPos;
    public bool onLeft, onMid, onRight;

    private void Start()
    {
        playerPos.transform.DOMoveY(0.0f, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Run", true);
        }        
        else if(Input.anyKey == false)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Idle", true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            float jumpingTime = 0.5f;
            playerPos.transform.DOMoveY(0.5f, jumpingTime);
            playerPos.transform.DOMoveY(0, 0.8f).SetDelay(jumpingTime);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && (onRight == true || onMid == true))
        {
            playerPos.transform.DOMoveX(playerPos.transform.position.x - 1.5f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && (onLeft == true || onMid == true))
        {
            playerPos.transform.DOMoveX(playerPos.transform.position.x + 1.5f, 0.5f);
        }
    }
}
