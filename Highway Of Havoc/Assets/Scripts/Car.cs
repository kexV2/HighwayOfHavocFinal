using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private AudioSource carAudioSource;
    public ParticleSystem smokeParticle;

    // Use this for initialization
    void Start()
    {
        // Get the AudioSource component attached to the car
        carAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the car is moving forward
        if (Input.GetAxis("Vertical") > 0)
        {
            // If the car is moving forward, play the car sound
            if (!carAudioSource.isPlaying)
            {
                carAudioSource.Play();
            }
        }
        else
        {
            // If the car is not moving forward, stop the car sound
            carAudioSource.Stop();
        }
    }
}