using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int Score;
    public AudioSource collect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GasCan"))
        {
            collect.Play();
            scoreText.GetComponent<Text>().text = "SCORE: " + Score;
            Destroy(other.gameObject); // Destroy the gas can instead of the current object.
        }
    }
}
