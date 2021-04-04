using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
<<<<<<< HEAD
    GameObject[] objects;

    void Start() {
        Time.timeScale = 1;
        objects = GameObject.FindGameObjectsWithTag("hasMovement");
=======
    GameObject[] pauseObjects;

    void Start() {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
>>>>>>> 9e62278bf6dbc1d9ae6066865d1b8b3e85958bb2
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.P)) {
            pauseControl();
        }
    }

<<<<<<< HEAD
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
=======
    public void Reload() {
        SceneManager.LoadScene("Game");
    }

    public void pauseControl() {
        if(Time.timeScale == 1) {
            Time.timeScale = 0;
            showPaused();
        } else if (Time.timeScale == 0) {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    public void showPaused() {
        foreach(GameObject g in pauseObjects) {
>>>>>>> 9e62278bf6dbc1d9ae6066865d1b8b3e85958bb2
            g.SetActive(true);
        }
    }

<<<<<<< HEAD
    public void pauseObjects() {
        foreach(GameObject g in objects) {
            g.SetActive(false);
        }
    }

    public void Reload() {
        SceneManager.LoadScene("Game");
    }

    public void Exit() {
        SceneManager.LoadScene("Start");
    }

    public void DEBUG() {
        Debug.Log("AQUI");
    }
=======
    public void hidePaused() {
        foreach(GameObject g in pauseObjects) {
            g.SetActive(false);
        }
    }
>>>>>>> 9e62278bf6dbc1d9ae6066865d1b8b3e85958bb2
}
