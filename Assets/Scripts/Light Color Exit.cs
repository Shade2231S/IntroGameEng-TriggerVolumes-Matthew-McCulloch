using UnityEngine;

public class LightColorExit : MonoBehaviour
{
    public Light light;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            light.color = Color.white;
        }
    }
}
