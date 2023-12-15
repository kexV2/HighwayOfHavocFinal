using UnityEngine;

public class GTNoise : MonoBehaviour
{
    public AudioClip gasTankSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(gasTankSound, transform.position);
            // You may want to add additional logic here, such as scoring or effects.
         
        }
    }
}
