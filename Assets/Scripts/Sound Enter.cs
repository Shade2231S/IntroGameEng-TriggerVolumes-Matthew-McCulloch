using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public AudioSource Audio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Audio.Play();
        }
    }
}
