using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
    GameObject[] objects;

    void Start() {
        Time.timeScale = 1;
        objects = GameObject.FindGameObjectsWithTag("hasMovement");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.P)) {
            pauseControl();
        }
    }

    public void pauseControl() {
        if(Time.timeScale == 1) {
            Time.timeScale = 0;
            pauseObjects();
        } else if (Time.timeScale == 0) {
            Time.timeScale = 1;
            playObjects();
        }
    }

    public void playObjects() {
        foreach(GameObject g in objects) {
            g.SetActive(true);
        }
    }

    public void pauseObjects() {
        foreach(GameObject g in objects) {
            g.SetActive(false);
        }
    }

    public void Restart() {
        SceneManager.LoadScene("GameStart");
    }

    public void Reload() {
        SceneManager.LoadScene("Game");
    }
}
