using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMove : MonoBehaviour {
    Vector3 target = Vector3.zero;
    Vector3 dogPos = Vector3.zero;
    Vector3 pos = Vector3.zero;
    bool sawDog = false;

    void Start() {
        target = transform.position;
    }

    private void FixedUpdate() {
        if(almostEqual(transform.position, target)) {
            dogPos = DogDirection();
            target = RandomDirection();
            if (sawDog || Vector3.Distance(dogPos, transform.position) < 100) {
                sawDog = true;
                target += dogPos;
            }
            else {
                target += transform.position;
            }
        }

        pos = Vector3.MoveTowards(transform.position, target, 1);
        GetComponent<Rigidbody2D>().MovePosition(pos);
    }

    Vector3 RandomDirection() {
        float random = Random.Range(0f, 260f);
        return 10 * new Vector3(Mathf.Cos(random), Mathf.Sin(random), 0);
    }

    Vector3 DogDirection() {
        GameObject dog = GameObject.Find("Dog");
        if (dog)
            return dog.transform.position;
        return Vector3.zero;
    }

    bool almostEqual(Vector2 u, Vector2 v) {
        return ((u - v).sqrMagnitude < Mathf.Pow(10, -4));
    }
}
