using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    bool gameHasEnded = false;
    public int  restartDelay=5;
    //to end the game
    public void endGame() {
        if (!gameHasEnded)
        {
            Debug.Log("LOLLL Game Manager is working!");
            gameHasEnded = true;
            FindObjectOfType<score>().restartText();
       
                Invoke("restart", restartDelay);
        }
    }



     void restart() {
        //this is method 1 to restart, where MainGame is the name of the ongoing Scene itself!
        SceneManager.LoadScene("MainGame");
        //or:
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void levelComplete() {
        Debug.Log("We finished boi!");
    }
}
