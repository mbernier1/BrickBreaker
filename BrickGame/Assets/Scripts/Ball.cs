using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool gameBegan = false;
    private Rigidbody2D ballRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameBegan == false) {

            this.transform.position = new Vector3(0, -2, 0);
        }

        if (Input.GetKey(KeyCode.Space)) {

            gameBegan = true;
            float ballVelocity = 5f;
            ballRigidbody.velocity = new Vector2(ballVelocity, ballVelocity);
        }
    }

    void OnCollisionEnter2D()
    {
        GetComponent<AudioSource>().Play();
    }
}
