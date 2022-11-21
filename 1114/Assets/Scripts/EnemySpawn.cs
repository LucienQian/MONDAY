using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public int a_Index;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //隨機產生亂數的索引值(0~2)
            int a_Index = Random.Range(0, 3);
            print("索引值是：" + a_Index);

            //生成敵人
            Instantiate(animalPrefab[a_Index], new Vector3(Random.Range(-15, 15), 0, 20), animalPrefab[a_Index]. transform.rotation);
        }
        

    }
}
