using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoneCoin : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "Dog") {
            Destroy(gameObject);
            GlobalVariables.score += 1;

            GameObject scoreText = GameObject.Find("ScoreText");
            scoreText.GetComponent<Text>().text = "SCORE   0000" + GlobalVariables.score.ToString();

            if(GlobalVariables.score == 5) {
                SceneManager.LoadScene("GameEnd");
            }
        }
    }

}
