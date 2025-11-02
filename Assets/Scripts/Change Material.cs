using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Material trimaterial;
    public Material orimaterial;
    public GameObject Ground;
    private Renderer GroundRenderer;

    void Start()
    {
        GroundRenderer = Ground.GetComponent<Renderer>();
        if (GroundRenderer != null)
        {
            orimaterial = GroundRenderer.material;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            GroundRenderer.material = trimaterial;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GroundRenderer.material = orimaterial;
        }
    }

}
