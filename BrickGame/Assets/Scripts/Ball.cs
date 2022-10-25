using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool gameBegan = false;
    public bool cloneBall = false;
    private Rigidbody2D ballRigidbody;
    float ballVelocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();

        if (cloneBall) {
            
            ballRigidbody.velocity = new Vector2(ballVelocity, ballVelocity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!cloneBall) {
            if (!gameBegan) {

                this.transform.position = new Vector3(0, -3, 0);
            }

            if (Input.GetKey(KeyCode.Space)) {

                gameBegan = true;
                ballRigidbody.velocity = new Vector2(ballVelocity, ballVelocity);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        GetComponent<AudioSource>().Play();

        float randomVelocityMin = 0f;
        float randomVelocityMax = 1f;
        Vector2 randomVelocity = new Vector2(
                Random.Range(randomVelocityMin, randomVelocityMax), 
                Random.Range(randomVelocityMin, randomVelocityMax));
        ballRigidbody.velocity += randomVelocity;
    }
}
