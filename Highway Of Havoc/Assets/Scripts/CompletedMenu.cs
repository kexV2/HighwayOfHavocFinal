using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletedMenu : MonoBehaviour
{
    // This function is called when the button is clicked
    public void CompleteMenu(string nameOfScene)
    {
        SceneManager.LoadScene(nameOfScene);
    }
}