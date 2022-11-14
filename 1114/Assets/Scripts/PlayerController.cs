using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float Hinput;
    public float xRange = 15; //�⭫�ƥX�{���Ʀr�Τ@���ܼƸ˸�
    public GameObject bullets;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hinput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * Hinput * speed);

        //����k�����ʽd��
        if (transform.position.x >= xRange)
        {
            //���a�V�k���ʶW�L����10����m�ɡA���a����m�̥���u�|�û����w�b10
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }else if (transform.position.x <= xRange)  //����������ʽd��
        {
            //���a�V�����ʶW�L����10����m�ɡA���a����m�̥���u�|�û����w�b10
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

        //�o�g�l�u�欰
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�l�u�o�g�X�h
            print("Fire!");
            Instantiate(foodBullet, transform.position, foodBulllet,.transform.rotation);
        }
    }
}
