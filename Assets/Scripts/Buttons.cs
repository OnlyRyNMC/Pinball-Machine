using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour{

    //Class my flippers buttons call to see if the button has been pressed
    public void AccClicked() {
        Flippers.Clicked = true;
    }

    //Class thats used to navigate between scenes using the order in the build settings
    public void LoadScene(int i) {
        SceneManager.LoadScene(i);
    }

    // Quit button function
    public void QuitGame() {
        Application.Quit();
    }

}
