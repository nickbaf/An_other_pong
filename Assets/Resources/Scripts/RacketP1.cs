using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketP1 : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
