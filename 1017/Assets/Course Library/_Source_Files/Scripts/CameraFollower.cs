using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [Header("�C������"), Tooltip("�Щ�A�n�H���C������")]
    public GameObject player;  //��m�w�q�϶�
    //�X�ݯŧO �ܼƫ��A �ܼƦW�� (= �ܼƼƭ�)

    [Header("��v�������q")]
    public Vector3 offset = new Vector3 (0, 5, -3);

    public float speed = 20; //�e�Ჾ���ܼ�

    public float trunspeed = 10; //���k���ʪ���    
    

    // Start �u����@��
    void Start()
    {
        
    }

    // Update �@������
    void LateUpdate()
    {
        //�⦹�{������m�ѷ�player�C�����󪺦�m + �����q
        transform.position = player.transform.position + offset; 
    }
}
