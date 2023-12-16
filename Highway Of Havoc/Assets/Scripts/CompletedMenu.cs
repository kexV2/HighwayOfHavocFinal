using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletedMenu : MonoBehaviour
{
    public int totalGasCans = 5; // Set this to the total number of gas cans in your scene
    private int collectedGasCans = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Optionally, you can initialize variables or perform setup here
    }

    // Update is called once per frame
    void Update()
    {
        // Optionally, you can perform continuous checks or updates here
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GasCan")) // Adjust the tag based on your gas can GameObject tag
        {
            collectedGasCans++;

            if (collectedGasCans >= totalGasCans)
            {
                ShowCompletedMenu();
            }

            Destroy(other.gameObject); // Remove the collected gas can from the scene
        }
    }

    private void ShowCompletedMenu()
    {
        SceneManager.LoadScene("CompletedMenu"); // Load the CompletedMenu scene
    }
}

