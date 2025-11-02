using UnityEngine;

public class AnimationDisable : MonoBehaviour
{
    public GameObject Cube;
    public Animator animator ;



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cube.SetActive(false);
            animator.enabled = false;
            //animator.SetTrigger("Cube-Animation");
        }
    }
}
