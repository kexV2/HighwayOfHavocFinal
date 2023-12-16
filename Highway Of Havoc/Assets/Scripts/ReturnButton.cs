using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    // This function is called when the button is clicked
    public void ReturnMenu(string nameOfScene)
    {
        SceneManager.LoadScene(nameOfScene);
    }
}