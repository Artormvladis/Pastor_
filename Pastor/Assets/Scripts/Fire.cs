using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

public class Fire : MonoBehaviour
{
    [SerializeField] XRInputValueReader<float> m_TriggerInput;
    [SerializeField] Rigidbody Bullet;

    void update()
    {
        if (m_TriggerInput != null)
        {
            Bullet.AddForce(transform.forward * 1f);
        }
    }
}
