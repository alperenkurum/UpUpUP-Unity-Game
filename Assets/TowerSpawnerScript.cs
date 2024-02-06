using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawnerScript : MonoBehaviour
{
    public GameObject tower ;
    public float spawnRate= 2;
    private float timer = 0;
    public float hightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
            SpawnTower();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnTower();
            timer = 0;
        }
       
    }
    void SpawnTower()
    {
        float lowestPoint = transform.position.y - hightOffset;
        float highestPoint = transform.position.y + hightOffset;

        Instantiate(tower, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);


    }
}
