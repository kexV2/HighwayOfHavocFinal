using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSmoke : MonoBehaviour
{
    public ParticleSystem smokeParticle;

    
    void Start()
    {
        // Get the ParticleSystem component attached to the car
        smokeParticle = GetComponent<ParticleSystem>();

        // Stop the particle system at the start
        smokeParticle.Stop();
    }

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