using UnityEngine;
using UnityEngine.XR.Intraction.Toolkit;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;
    public ActionBasedController controller;

    void Update()
    {
        float triggerValue = controller.activeAction.action.ReadValue<float>();
        if (triggerValue > 0.1f)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
    }
}
