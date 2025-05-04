using UnityEngine;

public class Knopkavnutri : MonoBehaviour
{
    [SerializeField] GameObject _canold;
    [SerializeField] GameObject _door1;
    [SerializeField] GameObject _door2;
    public static bool isPress1 = false;
    private void OnTriggerEnter(Collider other)
    {
        if (isPress1) return;
        _canold.transform.position += new Vector3(-0.02f, 0, 0);
        _door1.transform.position += new Vector3(-1, 0, 0);
        _door2.transform.position += new Vector3(1, 0, 0);
        isPress1 = true;
    }
}
