using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogMove : MonoBehaviour {
    Vector2 target;
    public float speed = 10;
    public SkeletonMove skeleton;

    void Start() {
        target = transform.position;
    }

    void FixedUpdate() {
        Vector2 p = Vector2.MoveTowards(transform.position, target, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        if (almostEqual((Vector2)transform.position, target)) {
            if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up)){
                target = (Vector2)transform.position + speed * Vector2.up;
            }
            if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right)){
                target = (Vector2)transform.position + speed * Vector2.right;
            }
            if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up)){
                target = (Vector2)transform.position - speed * Vector2.up;
            }
            if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right)){
                target = (Vector2)transform.position - speed * Vector2.right;
            }
        } else if (Vector3.Distance(transform.position, target) < 1) {
            target = transform.position;
        }


        Vector2 dir = target - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "Maze") {
            transform.position = GlobalVariables.initialPosition();
            target = (Vector2) transform.position;
        }
        if (co.tag == "Enemy") {
            Time.timeScale = 0;
            SceneManager.LoadScene("Lost");
        }
    }

    bool valid(Vector2 dir) {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }

    bool almostEqual(Vector2 u, Vector2 v) {
        return ((u - v).sqrMagnitude < Mathf.Pow(10, -4));
    }
}
