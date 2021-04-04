using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeCountdown : MonoBehaviour {
    public float timeLeft = 60.0f;

    void Update() {
        timeLeft -= Time.deltaTime;
        Debug.Log(timeLeft);
        if (timeLeft < 0) {
            SceneManager.LoadScene("Lost");
        }
    }
}
