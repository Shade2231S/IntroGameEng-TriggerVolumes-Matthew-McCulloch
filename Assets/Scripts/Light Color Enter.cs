using UnityEngine;

public class LightColor : MonoBehaviour
{
    public Light light;

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
        {
            light.color = Color.red;
        }
    }
}
