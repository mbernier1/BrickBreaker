using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private const float PaddleSpeed = 3f;
    private Vector3 paddlePosition;
    private float minXPosition = -1.66f;
    private float maxXPosition = 1.66f;

    // Start is called before the first frame update
    void Start()
    {
        paddlePosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float paddlePositionX = this.transform.position.x;

        if (Input.GetKey(KeyCode.LeftArrow)) {

            paddlePositionX -= PaddleSpeed * Time.deltaTime;
            //this.transform.position = new Vector3(paddlePositionX,
                   // this.transform.position.y, this.transform.position.z);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {

            paddlePositionX += PaddleSpeed * Time.deltaTime;
            
        }

        paddlePosition.x = Mathf.Clamp(paddlePositionX, 
                minXPosition, maxXPosition);
        this.transform.position = paddlePosition;
    }

    //make a sound when the ball hits something
    
}
