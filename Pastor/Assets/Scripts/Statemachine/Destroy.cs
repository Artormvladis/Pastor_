using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject m_gameObject;
    [SerializeField] private Animator animator;

    public void Update()
    {
        if (animator.GetBool("Isdead") == true)
        {
            Destroy(m_gameObject, 10f);
        }
    }
}
