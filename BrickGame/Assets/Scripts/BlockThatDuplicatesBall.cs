using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockThatDuplicatesBall : MonoBehaviour
{
    public GameObject ballPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject ballObject = Instantiate(ballPrefab);

        Ball ball = ballObject.GetComponent<Ball>();
        ball.cloneBall = true;

        ball.transform.position = collision.gameObject.transform.position;
    }
}
