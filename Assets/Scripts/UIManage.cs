using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManage : MonoBehaviour {
    [SerializeField] private TMP_Text theText;
    static public int score;

    //setting the life count to 3 at the start of the game
    private void Awake() {
        Flippers.lives = 3;
    }

    public void Update() {
        // setting the score and amount of lives to appear in my level
        theText.text = "Score: " + score + "\n Lives: " + Flippers.lives;
        score = Flippers.score;
        //if the player loses all there lives, the game over screen appears
        if (Flippers.lives == 0) {
            SceneManager.LoadScene(3);
        }
    }

}
