using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float movementSpeed;
    public float acceleration;
    public float maximumSpeed;
    int hitCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartMovement());
    }

    public IEnumerator StartMovement(bool startingPlayer = true)
    {
        this.PositionBall(startingPlayer);
        this.hitCount = 0;
        yield return new WaitForSeconds(1);
        if (startingPlayer)
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }
    public void MoveBall(Vector2 direction)
    {   
        //Debug.Log("bounce");
        Debug.Log(direction);
        direction = direction.normalized;
        Debug.Log(direction);


        float speed = this.movementSpeed + this.hitCount * this.acceleration;
        Rigidbody2D rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = direction * speed;
    }


    public void IncreaseCounter()
    {
        if(this.hitCount*this.acceleration <= this.maximumSpeed)
        {
            this.hitCount++;
        }
    }

    void PositionBall(bool isP1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (isP1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }

}
