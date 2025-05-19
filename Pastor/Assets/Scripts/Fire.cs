using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using static UnityEngine.GraphicsBuffer;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 0.05f;
    [SerializeField] XRInputValueReader<float> m_TriggerInput;
    [SerializeField] XRInputValueReader<float> m_GripInput;
    [SerializeField] Transform target;
    bool nfired = true;
    [SerializeField] int patrons;

    void Update()
    {
        if (m_TriggerInput.ReadValue() > 0.1f && nfired && patrons>0 && m_GripInput.ReadValue() > 0.1f && DistToTarget() < 0.1)
        {
            Shoot();
            nfired = false;
            patrons -= 1;
        }
        if (m_TriggerInput.ReadValue() <= 0.1f)
        {
            nfired = true;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode.Force);
    }

    public float DistToTarget()
    {
        return (transform.position - target.transform.position).magnitude;
    }
}
