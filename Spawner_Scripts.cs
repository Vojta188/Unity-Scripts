using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScripts : MonoBehaviour

{
    public GameObject enemy;
    float randX;
    Vector2 WhereToSpawn;
    public float spawnRate = 1f;
    float nextSpawn = 0.0f;
    float collision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {       
            nextSpawn = Time.time +  spawnRate;
            randX = Random.Range (-15f, 15f);
            WhereToSpawn = new Vector2(randX,transform.position.y);
            Instantiate(enemy, WhereToSpawn, Quaternion.identity);
        }
        }

    

   
}
