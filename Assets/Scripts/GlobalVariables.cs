using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables {
    public static int score = 0;

    public static Vector3 initialPosition(){
        return (new Vector3(Random.Range(-50.0f, 60.0f), Random.Range(60.0f, 240.0f), 0));
    }
}
