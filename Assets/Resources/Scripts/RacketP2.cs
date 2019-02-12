using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketP2: MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }


}
