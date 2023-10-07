using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Flippers : MonoBehaviour{
    //boolean used across other scripts to see if the flipper buttons have been pressed
    static public Boolean Clicked;
    //gameObject pinball
    private GameObject pinball;
    //amount of the ball is pushed back by when it collides with the flipper
    [SerializeField] private float fling;
    static public int score;
    static public int lives;

    private void Awake() {
        //finding the pinball from my scene
        pinball = GameObject.Find("Pinball");
        fling = 500;
        score = 0;
    }

    
    //checking if the pinball is colliding with the filpper and the flippers button has been pressed
    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject == pinball && Clicked == true) {
            //adding force to the pinball so it flies off
            pinball.GetComponent<Rigidbody>().AddForce(Vector3.up * fling);
        }
    }

    //setting clicked as false as soon as the ball leaves the flipper
    private void OnCollisionExit(Collision collision) {
        Clicked = false;
    }

}
