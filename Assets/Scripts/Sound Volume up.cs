using UnityEngine;
using UnityEngine.Audio;

public class SoundVolumeup : MonoBehaviour
{
    public AudioSource audio;
    public float volumeup = 0.1f;
    public float limit = 0.6f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio.volume = Mathf.Clamp(audio.volume + volumeup, 0f, limit);
        }
    }
}
