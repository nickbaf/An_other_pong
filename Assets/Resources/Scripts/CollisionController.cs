using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController sC;
    void BounceFromRacket(Collision2D c)
    {


        Vector3 position = this.transform.position;
        Vector3 racketPos = c.gameObject.transform.position;

        float racketHight = c.collider.bounds.size.y;
        float x;
        if (c.gameObject.name == "RacketP1")
        {
            x = 1;
        }
        else 
        {
            x = -1;
        }

        float y = ((position.y - racketPos.y) / racketHight);
        ballMovement.IncreaseCounter();
        ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.name == "RacketP1" || collision.gameObject.name == "RacketP2")
        {
            Debug.Log("racket");
            this.BounceFromRacket(collision);
        }
        else if(collision.gameObject.name=="WallLeft")
        {
            Debug.Log("left");
            sC.GoalP2();
            StartCoroutine(this.ballMovement.StartMovement(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("right");
            sC.GoalP1();
            StartCoroutine(this.ballMovement.StartMovement(false));
        }
    }
}
