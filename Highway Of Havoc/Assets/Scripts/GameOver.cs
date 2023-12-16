using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object tagged as "Cones"
        if (collision.gameObject.CompareTag("Cones"))
        {
            // Log a message to ensure that the collision is detected
            Debug.Log("Collided with Cones");

            // Game over scenario: Load the "Menu" scene
            SceneManager.LoadScene("ReturnMenu");
        }
    }
}
