using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class feedbacker : MonoBehaviour{
    //Creating a tag to compare if the ball touches the feedbacker
    const string BALL = "Pinball";
    public UnityEvent Bounced;


    //If player touches something
    private void OnCollisionEnter(Collision collision) {
        //If something collides with something with the "Pinball" tag
        if (collision.gameObject.CompareTag(BALL)) {
            //lose a life
            Flippers.lives -= 1;
            Debug.Log(Flippers.lives);
            //Print to console "Ball collided"
            Debug.Log("Ball Collided");
            //Do the action
            Bounced.Invoke();
        }
    }
}
