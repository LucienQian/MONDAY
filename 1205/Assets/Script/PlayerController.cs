using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRB;
    public float jumpForce = 10;
    public float gravityMod = 1;

    public bool isOnGround = true; //是否貼合地板
    
    void Start()
    {
        //獲得剛體的控制權
        playerRB = GetComponent<Rigidbody>();
        //playerRB.AddForce(Vector3.up * 1000); //針對此剛體施加力道.方向*力量
        Physics.gravity = Physics.gravity * gravityMod;  //Physics.gravity *= gravityMod;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false; //切換：false
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true; //切換回：true
    }
}
