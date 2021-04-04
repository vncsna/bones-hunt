using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestOpen : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "Dog") {
            Destroy(gameObject);
            GlobalVariables.score += 1;
            if(GlobalVariables.score == 5) {
                SceneManager.LoadScene("Won");
            }
        }
    }

}
