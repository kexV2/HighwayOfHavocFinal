using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtrl : MonoBehaviour
{
    // This function is called when the button is clicked
    public void ChangeLvl(string nameOfScene)
    {
        SceneManager.LoadScene(nameOfScene);
    }
}