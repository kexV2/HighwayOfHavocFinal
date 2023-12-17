using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollection : MonoBehaviour
{
    private int Coin = 0;
    public int maxCoinsInCurrentLevel = 15; // Set the initial maximum coins 
    public TextMeshProUGUI Score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin++;
            Score.text = "Score: " + Coin.ToString();
            Destroy(other.gameObject);

            // Check if the current level's coin count has reached its maximum
            if (Coin == maxCoinsInCurrentLevel)
            {
                // Load the CompletedMenu scene
                SceneManager.LoadScene("CompleteMenu"); 
            }
        }
    }
}