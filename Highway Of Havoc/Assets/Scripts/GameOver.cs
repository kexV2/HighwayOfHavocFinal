using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object tagged as "Cones"
        if (collision.gameObject.CompareTag("Cones"))
        {
            
            // Game over scenario: Load the "Menu" scene
            SceneManager.LoadScene("ReturnMenu");
        }
    }
}
