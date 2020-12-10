using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawn = 9;
    public GameObject enemyPrefab; // then we have to attach the enemy prefab (variable then assign the prefab in the inspector)

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(enemyPrefab, SpawnEnemys(), enemyPrefab.transform.rotation); // we do the rotation , so we can get the excat things that was in our enemy prefab --> so this will create a new enemy 
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private  Vector3 SpawnEnemys() // we dont need to use it in antoehr class , and we need to use return becuase it a method and not void 
    {
        float spawnForZ = Random.Range(-spawn, spawn);
        float spawnForX = Random.Range(-spawn, spawn);
        Vector3 randomPostion = new Vector3(spawnForX, 0, spawnForZ); // creating new vector 3 postion for the enemys 


        return randomPostion; // so this method will retrun the random vector3 ranges that wee need , so when we call the method in the instantiate the randpostion will retrun 
       

    }
}
