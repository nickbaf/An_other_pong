using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource wall;
    public AudioSource racket;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="RacketP1"|| collision.gameObject.name == "RacketP2")
        {
            this.racket.Play();
        }
        else
        {
            this.wall.Play();

        }
    }
}
