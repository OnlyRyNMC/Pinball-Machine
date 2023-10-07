using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

//Script for the bouncePad on the second level
public class bouncy2 : MonoBehaviour {
    //Creating a tag to compare if the ball touches the bounce pad
    const string BALL = "Pinball";
    public UnityEvent Bounced;
    public UnityEvent BouncedOff;


    //If the pinball touches the bouncePad
    private void OnCollisionEnter(Collision collision) {
        //If something collides with something with the "Pinball" tag
        if (collision.gameObject.CompareTag(BALL)) {
            //increase score by 50
            Flippers.score += 50;
            Debug.Log(Flippers.score);
            //Print to console "Bounce Collided"
            Debug.Log("Bounce Collided");
            //Do the action
            Bounced.Invoke();
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.CompareTag(BALL)) {
            //check to see if the pinball is off the bouncePad
            Debug.Log("Bounced Off");
            BouncedOff.Invoke();
        }
    }
}
