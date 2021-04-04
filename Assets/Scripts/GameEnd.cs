using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {
    void Start() {
        Text box = GetComponent<Text>();

        if (box.text == "title")
            if(GlobalVariables.score == 5)
                box.text = "YOU WON";
            else
                box.text = "YOU LOST";

        if (box.text == "score")
            box.text = GlobalVariables.score.ToString();
    }
}
