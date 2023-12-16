using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSmoke : MonoBehaviour
{
    private ParticleSystem smokeParticle;

    // Use this for initialization
    void Start()
    {
        // Get the ParticleSystem component attached to the car
        smokeParticle = GetComponent<ParticleSystem>();

        // Stop the particle system at the start
        smokeParticle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the car is moving forward
        if (Input.GetAxis("Vertical") > 0)
        {
            // If the car is moving forward and the particle system is not playing, start it
            if (!smokeParticle.isPlaying)
            {
                smokeParticle.Play();
            }
        }
        else
        {
            // If the car is not moving forward or the particle system is playing, stop it
            if (smokeParticle.isPlaying)
            {
                smokeParticle.Stop();
            }
        }
    }
}