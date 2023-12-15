using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyChange : MonoBehaviour
{
    public string menuName;
    private void ChangeSceneDelayed()
    {
        // Load the game over scene
        SceneManager.LoadScene(menuName);
    }
}