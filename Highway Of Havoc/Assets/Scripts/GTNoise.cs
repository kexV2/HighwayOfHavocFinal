using UnityEngine;

public class GTNoise : MonoBehaviour
{
    public AudioClip gasTankSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(gasTankSound, transform.position);
            
         
        }
    }
}
