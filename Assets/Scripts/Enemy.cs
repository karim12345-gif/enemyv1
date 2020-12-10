using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRB ;
    private GameObject player;
    public float speedOfEnemy = 5.0f;  // for the enemy to move 



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");// reference 
        enemyRB = GetComponent<Rigidbody>(); // refrence
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRB.AddForce(lookDirection * speedOfEnemy); // we subtract the player and the enemys current postiin to get the vector 3 postion , and then we * it by the speed of the eneny , if we do this 
        // the enemy can go and attack the player, however if we keep it like that the enemy gets more force over time if the player is far away from the enemy , thereofre makes the have more power and force which is not good you cant play the game 
        // so that's why we use normalized --> so this will normalize the magnitude of this vector , so it doesnt mattter how close or how far the enemy is from the player , it will be always coming at the same speed. 
         
    }
}
