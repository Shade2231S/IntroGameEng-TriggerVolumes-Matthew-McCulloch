using UnityEngine;

public class NewMonoBehaviourScript2 : MonoBehaviour
{
    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio.Stop();
        }
    }
}
