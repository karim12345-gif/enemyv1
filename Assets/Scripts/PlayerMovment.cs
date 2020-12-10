using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    private float PlayerSpeed = 7.0f;
    public Rigidbody playerRB;
    private GameObject focalPoint;
    public bool hasPowerUp = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>(); // reference for the player 
        focalPoint = GameObject.Find("FocalPoint"); // this is going to find the name of the game obhect in then heircary  , still a reference 

    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical"); // moves forward or backwards

        playerRB.AddForce(focalPoint.transform.forward * PlayerSpeed * forwardInput); // this will move the player with the camera roation or movement ( as the camera moves the player moves with it somehow)


    }


    private void OnTriggerEnter(Collider other) // "other" is referring to the other collider that the GameObject intersected with. player one is object1 , object 2 is the power up 
    {
        if (other.CompareTag("Powerup")) // other refereing to the power up over here , becuase we wanna destroy the power up not the player 
        {
            hasPowerUp = true; // if its true , then we destory 
            Destroy(other.gameObject);
        }
    }
}
