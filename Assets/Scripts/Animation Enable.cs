using UnityEngine;

public class Animation : MonoBehaviour
{

    public GameObject Cube;
    public Animator animator;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cube.SetActive(true);
            animator.enabled = true;
            //animator.SetTrigger("Cube-Animation");
        }
    }

}
