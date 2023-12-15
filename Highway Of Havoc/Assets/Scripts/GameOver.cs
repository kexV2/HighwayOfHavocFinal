using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object tagged as "Cone"
        if (collision.gameObject.CompareTag("Cones"))
        {
            // Game over scenario: Reload the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}