using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    int curPos = 0;
    int nextPos = 1;


    private void FixedUpdate()
    {
        if (target.Length!=nextPos) {
            transform.position = Vector3.MoveTowards(transform.position, target[nextPos].position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, target[nextPos].position) <= 0)
            {
                curPos = nextPos;
                nextPos++;

            }
        }
       

        

    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag=="Player1") {
            SceneManager.LoadScene("WinP2");
        }
        if (other.gameObject.tag == "Player2")
        {
            SceneManager.LoadScene("WinP1");
        }

    }
}
