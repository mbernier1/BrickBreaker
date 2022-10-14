using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private const float PaddleSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float paddlePositionX = this.transform.position.x;

        if (Input.GetKey(KeyCode.LeftArrow)) {

            paddlePositionX -= PaddleSpeed * Time.deltaTime;
            this.transform.position = new Vector3(paddlePositionX,
                    this.transform.position.y, this.transform.position.z);
        }
        
    }
}
