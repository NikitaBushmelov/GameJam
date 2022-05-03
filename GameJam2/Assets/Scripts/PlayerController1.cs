using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController1 : MonoBehaviour
{
    bool moveLeft;
    bool moveRight;
    Rigidbody2D rb2d;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveLeft = Input.GetKey(KeyCode.A);
        moveRight= Input.GetKey(KeyCode.D);
    }
    private void FixedUpdate()
    {
        if (moveLeft) {
            rb2d.AddForce(new Vector2(-speed,0f));
        }
        if (moveRight)
        {
            rb2d.AddForce(new Vector2(speed, 0f));
        }
    }
    private void OnCollision2D(Collider other) {
        if (other.gameObject.tag=="WinFlag") {
            SceneManager.LoadScene("WinP1");
        }
    }
}
