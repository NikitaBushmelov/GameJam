using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform[] target;
    float speed=3;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player1")) { 
            
        }
        if(collision.collider.CompareTag("Player2")) {

        }
    }
}
